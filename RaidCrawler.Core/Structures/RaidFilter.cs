using System.Diagnostics.Metrics;
using PKHeX.Core;

namespace RaidCrawler.Core.Structures;

public class RaidFilter
{
    public string? Name { get; set; }
    public int? Species { get; set; }
    public bool RareVariant { get; set; }
    public int? Form { get; set; }
    public int? Stars { get; set; }
    public int StarsComp { get; set; }
    public bool Shiny { get; set; }
    public bool Square { get; set; }
    public bool EventExcluded { get; set; }
    public int? Nature { get; set; }
    public int? TeraType { get; set; }
    public int? Gender { get; set; }
    public int? Size { get; set; }
    public int IVBin { get; set; }
    public int IVComps { get; set; }
    public int IVVals { get; set; }
    public bool Enabled { get; set; }
    public int[]? RewardItems { get; set; }
    public int RewardsComp { get; set; }
    public int RewardsCount { get; set; }
    public string[]? BatchFilters { get; set; }

    public bool IsFilterSet() => Species != null
                              || RareVariant
                              || Form != null
                              || Stars != null
                              || Shiny
                              || Square
                              || EventExcluded
                              || Nature != null
                              || TeraType != null
                              || Gender != null
                              || Size != null
                              || IVBin != 0
                              || (RewardItems != null && RewardsCount != 0)
                              || BatchFilters != null;

    public bool IsSpeciesSatisfied(ushort species)
    {
        if (Species is null)
            return true;

        return species == (ushort)Species;
    }

    public bool IsRareVariantSatisfied(Raid raid)
    {
        if (RareVariant == false)
            return true;
        return raid.EC % 100 == 0;
    }

    public bool IsFormSatisfied(byte form)
    {
        if (Form is null)
            return true;

        return form == Form;
    }

    public bool IsStarsSatisfied(ITeraRaid enc)
    {
        if (Stars is null)
            return true;

        return StarsComp switch
        {
            0 => enc.Stars == Stars,
            1 => enc.Stars > Stars,
            2 => enc.Stars >= Stars,
            3 => enc.Stars <= Stars,
            4 => enc.Stars < Stars,
            _ => false,
        };
    }

    public bool IsRewardsSatisfied(RaidContainer container, ITeraRaid enc, Raid raid, int sandwichBoost)
    {
        if (RewardItems is null || RewardsCount == 0)
            return true;

        var rewards = enc.GetRewards(container, raid, sandwichBoost);
        var count = rewards.Where(z => RewardItems.Contains(z.Item1)).Sum(o => o.Item2);
        return RewardsComp switch
        {
            0 => count == RewardsCount,
            1 => count > RewardsCount,
            2 => count >= RewardsCount,
            3 => count <= RewardsCount,
            4 => count < RewardsCount,
            _ => false,
        };
    }

    public bool IsShinySatisfied(PK9 blank)
    {
        if (!Shiny)
            return true;

        return blank.IsShiny;
    }

    public bool IsSquareSatisfied(PK9 blank)
    {
        if (!Square)
            return true;

        return blank.IsShiny && ShinyExtensions.IsSquareShinyExist(blank);
    }

    public bool IsEventExcluded(Raid raid)
    {
        if (!EventExcluded)
            return true;

        return !raid.IsEvent;
    }

    public bool IsTeraTypeSatisfied(Raid raid, ITeraRaid enc)
    {
        if (TeraType is null)
            return true;

        return raid.GetTeraType(enc) == TeraType;
    }

    public bool IsNatureSatisfied(int nature)
    {
        if (Nature is null)
            return true;

        return nature == Nature;
    }

    public bool IsIVsSatisfied(PK9 blank)
    {
        if (IVBin == 0)
            return true;

        Span<int> _ivs = stackalloc int[6];
        blank.GetIVs(_ivs);
        var ivs = Utils.ToSpeedLast(_ivs);
        for (int i = 0; i < 6; i++)
        {
            var iv = IVVals >> i * 5 & 31;
            var ivbin = IVBin >> i & 1;
            var ivcomp = IVComps >> i * 3 & 7;
            if (ivbin != 1)
                continue;
            if (!IsValidIV(ivcomp, ivs, i, iv))
                return false;
        }
        return true;
    }

    private static bool IsValidIV(int ivcomp, ReadOnlySpan<int> ivs, int index, int iv) => ivcomp switch
    {
        0 => ivs[index] == iv,
        1 => ivs[index] > iv,
        2 => ivs[index] >= iv,
        3 => ivs[index] <= iv,
        4 => ivs[index] < iv,
        _ => true,
    };

    public bool IsGenderSatisfied(ITeraRaid encounter, int gender)
    {
        if (Gender is null || (encounter.Gender <= 2 && encounter.Gender == Gender))
            return true;

        return gender == Gender;
    }

    public bool IsSizeSatisfied(ITeraRaid? enc, Raid raid)
    {
        if (Size == null)
            return true;
        if (enc == null)
            return false;

        var param = enc.GetParam();
        var blank = new PK9()
        {
            Species = enc.Species,
            Form = enc.Form
        };
        raid.GenerateDataPK9(blank, param, enc.Shiny, raid.Seed);
        var size = $"{PokeSizeDetailedUtil.GetSizeRating(blank.Scale)}";
        var result = 0;
        switch (size)
        {
            case "XXXS":
                result = 0;
                break;
            case "XXS":
                result = 1;
                break;
            case "XS":
                result = 2;
                break;
            case "S":
                result = 3;
                break;
            case "AV":
                result = 4;
                break;
            case "L":
                result = 5;
                break;
            case "XL":
                result = 6;
                break;
            case "XXL":
                result = 7;
                break;
            case "XXXL":
                result = 8;
                break;
        }

        return result == Size;
    }

    public bool IsBatchFilterSatisfied(PK9 blank)
    {
        if (BatchFilters is null)
            return true;

        var filters = StringInstruction.GetFilters(BatchFilters.AsSpan());
        if (filters.Count == 0)
            return true;

        BatchEditing.ScreenStrings(filters);
        return BatchEditing.IsFilterMatch(filters, blank);
    }

    public bool FilterSatisfied(
        RaidContainer container,
        ITeraRaid enc,
        Raid raid,
        int SandwichBoost
    )
    {
        var param = enc.GetParam();
        var blank = new PK9 { Species = enc.Species, Form = enc.Form };

        raid.GenerateDataPK9(blank, param, enc.Shiny, raid.Seed);

        return Enabled
               && IsIVsSatisfied(blank)
               && IsShinySatisfied(blank)
               && IsSquareSatisfied(blank)
               && IsEventExcluded(raid)
               && IsSpeciesSatisfied(blank.Species)
               && IsRareVariantSatisfied(raid)
               && IsFormSatisfied(blank.Form)
               && IsNatureSatisfied((int)blank.Nature)
               && IsStarsSatisfied(enc)
               && IsTeraTypeSatisfied(raid, enc)
               && IsRewardsSatisfied(container, enc, raid, SandwichBoost)
               && IsGenderSatisfied(enc, blank.Gender)
               && IsSizeSatisfied(enc, raid)
               && IsBatchFilterSatisfied(blank);
    }

    public bool FilterSatisfied(
        RaidContainer container,
        IReadOnlyList<ITeraRaid> encounters,
        IReadOnlyList<Raid> raids,
        int sandwichBoost
    )
    {
        if (raids.Count != encounters.Count)
            throw new Exception("Raid count does not match Encounter count");

        for (int i = 0; i < raids.Count; i++)
        {
            if (FilterSatisfied(container, encounters[i], raids[i], sandwichBoost))
                return true;
        }
        return false;
    }
}
