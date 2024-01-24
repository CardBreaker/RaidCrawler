using PKHeX.Core;
using RaidCrawler.Core.Structures;
using System.Collections;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RaidCrawler.WinForms.SubForms;

public partial class FilterSettings : Form
{
    private readonly List<RaidFilter> allFilters;
    private readonly RaidFilterCollection displayFilters;

    private readonly BindingSource bs = new();

    private readonly Color SearchActiveColor = Color.Aquamarine;
    private readonly Color SearchInactiveColor = Color.Empty;

    public FilterSettings(ref List<RaidFilter> filters)
    {
        InitializeComponent();
        allFilters = filters;
        displayFilters = new RaidFilterCollection(ref allFilters, SearchBar);
        Species.DataSource = Enum.GetValues(typeof(Species))
            .Cast<Species>()
            .Where(z => z != PKHeX.Core.Species.MAX_COUNT)
            .ToArray();
        Nature.DataSource = Enum.GetValues(typeof(Nature));
        TeraType.DataSource = Enum.GetValues(typeof(MoveType))
            .Cast<MoveType>()
            .Where(z => z != MoveType.Any)
            .ToArray();

        Stars.SelectedIndex = 0;
        StarsComp.SelectedIndex = 0;
        HPComp.SelectedIndex = 0;
        AtkComp.SelectedIndex = 0;
        DefComp.SelectedIndex = 0;
        SpaComp.SelectedIndex = 0;
        SpdComp.SelectedIndex = 0;
        SpeComp.SelectedIndex = 0;

        bs.DataSource = displayFilters;
        ActiveFilters.DataSource = bs;
        ActiveFilters.DisplayMember = "Name";

        ResetActiveFilters();
        if (ActiveFilters.Items.Count > 0)
            ActiveFilters.SelectedIndex = 0;
        if (ActiveFilters.SelectedIndex == -1)
            Remove.Enabled = false;
    }

    public void ResetActiveFilters()
    {
        // Seems like a .NET bug - ResetBindings() won't do anything even
        // if the filters changed unless its reference changes.
        bs.DataSource = null;

        if (displayFilters.Count > 0)
        {
            bs.DataSource = displayFilters;
        }

        bs.ResetBindings(false);

        if (displayFilters.Count <= 0)
        {
            ActiveFilters.SelectedIndex = -1;
        }

        for (int i = 0; i < displayFilters.Count; i++)
            ActiveFilters.SetItemChecked(i, displayFilters[i].Enabled);
    }

    public void SelectFilter(RaidFilter filter)
    {
        FilterName.Text = filter.Name;
        Species.SelectedIndex = filter.Species ?? 0;
        RareVariant.Checked = filter.RareVariant;
        Form.Value = filter.Form ?? 0;
        Nature.SelectedIndex = filter.Nature ?? 0;
        Stars.SelectedIndex = filter.Stars != null ? (int)filter.Stars - 1 : 0;
        StarsComp.SelectedIndex = filter.StarsComp;
        TeraType.SelectedIndex = filter.TeraType ?? 0;
        Gender.SelectedIndex = filter.Gender ?? 0;
        SizeBox.SelectedIndex = filter.Size ?? 0;
        SpeciesCheck.Checked = filter.Species != null;
        FormCheck.Checked = filter.Form != null;
        NatureCheck.Checked = filter.Nature != null;
        StarCheck.Checked = filter.Stars != null;
        TeraCheck.Checked = filter.TeraType != null;
        GenderCheck.Checked = filter.Gender != null;
        SizeCheck.Checked = filter.Size != null;
        ShinyCheck.Checked = filter.Shiny;
        SquareCheck.Checked = filter.Square;
        CheckRewards.Checked = filter is { RewardItems: not null, RewardsCount: > 0 };
        Rewards.Text = filter.RewardItems != null
            ? string.Join(",", filter.RewardItems.Select(x => x.ToString()).ToArray())
            : "645,795,1606,1904,1905,1906,1907,1908";
        RewardsComp.SelectedIndex = filter.RewardsComp;
        RewardsCount.Value = filter.RewardsCount;
        BatchFilters.Text = filter.BatchFilters != null
            ? string.Join(Environment.NewLine, filter.BatchFilters)
            : string.Empty;

        var ivbin = filter.IVBin;
        HP.Checked = (ivbin & 1) == 1;
        Atk.Checked = ((ivbin >> 1) & 1) == 1;
        Def.Checked = ((ivbin >> 2) & 1) == 1;
        SpA.Checked = ((ivbin >> 3) & 1) == 1;
        SpD.Checked = ((ivbin >> 4) & 1) == 1;
        Spe.Checked = ((ivbin >> 5) & 1) == 1;

        var ivvals = filter.IVVals;
        IVHP.Value = ivvals & 31;
        IVATK.Value = (ivvals >> 5) & 31;
        IVDEF.Value = (ivvals >> 10) & 31;
        IVSPA.Value = (ivvals >> 15) & 31;
        IVSPD.Value = (ivvals >> 20) & 31;
        IVSPE.Value = (ivvals >> 25) & 31;

        var ivcomp = filter.IVComps;
        HPComp.SelectedIndex = (ivcomp & 7);
        AtkComp.SelectedIndex = (ivcomp >> 3) & 7;
        DefComp.SelectedIndex = (ivcomp >> 6) & 7;
        SpaComp.SelectedIndex = (ivcomp >> 9) & 7;
        SpdComp.SelectedIndex = (ivcomp >> 12) & 7;
        SpeComp.SelectedIndex = (ivcomp >> 15) & 7;

        IVHP.Enabled = HP.Checked;
        IVATK.Enabled = Atk.Checked;
        IVDEF.Enabled = Def.Checked;
        IVSPA.Enabled = SpA.Checked;
        IVSPD.Enabled = SpD.Checked;
        IVSPE.Enabled = Spe.Checked;

        HPComp.Enabled = HP.Checked;
        AtkComp.Enabled = Atk.Checked;
        DefComp.Enabled = Def.Checked;
        SpaComp.Enabled = SpA.Checked;
        SpdComp.Enabled = SpD.Checked;
        SpeComp.Enabled = Spe.Checked;

        Species.Enabled = SpeciesCheck.Checked;
        RareVariant.Visible = Species.SelectedIndex == 206 || Species.SelectedIndex == 924;
        Nature.Enabled = NatureCheck.Checked;
        Stars.Enabled = StarCheck.Checked;
        StarsComp.Enabled = StarCheck.Checked;
        Rewards.Enabled = CheckRewards.Checked;
        ButtonOpenRewardsList.Enabled = CheckRewards.Checked;
        RewardsCount.Enabled = CheckRewards.Checked;
        RewardsComp.Enabled = CheckRewards.Checked;
        TeraType.Enabled = TeraCheck.Checked;
        Gender.Enabled = GenderCheck.Checked;
        SizeBox.Enabled = SizeCheck.Checked;
    }

    private void Add_Filter_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(FilterName.Text))
        {
            MessageBox.Show("Name is a required field!");
            return;
        }

        RaidFilter filter = new();
        var ivbin =
            ToInt(HP.Checked) << 0
            | ToInt(Atk.Checked) << 1
            | ToInt(Def.Checked) << 2
            | ToInt(SpA.Checked) << 3
            | ToInt(SpD.Checked) << 4
            | ToInt(Spe.Checked) << 5;
        var ivcomps =
            HPComp.SelectedIndex << 0
            | AtkComp.SelectedIndex << 3
            | DefComp.SelectedIndex << 6
            | SpaComp.SelectedIndex << 9
            | SpdComp.SelectedIndex << 12
            | SpeComp.SelectedIndex << 15;
        var ivvals =
            (int)IVHP.Value << 0
            | (int)IVATK.Value << 5
            | (int)IVDEF.Value << 10
            | (int)IVSPA.Value << 15
            | (int)IVSPD.Value << 20
            | (int)IVSPE.Value << 25;

        filter.Name = FilterName.Text.Trim();
        filter.Species = SpeciesCheck.Checked ? Species.SelectedIndex : null;
        filter.RareVariant = RareVariant.Checked;
        filter.Form = FormCheck.Checked ? (int)Form.Value : null;
        filter.Nature = NatureCheck.Checked ? Nature.SelectedIndex : null;
        filter.Stars = StarCheck.Checked ? Stars.SelectedIndex + 1 : null;
        filter.StarsComp = StarsComp.SelectedIndex;
        filter.TeraType = TeraCheck.Checked ? TeraType.SelectedIndex : null;
        filter.Gender = GenderCheck.Checked ? Gender.SelectedIndex : null;
        filter.Size = SizeCheck.Checked ? SizeBox.SelectedIndex : null;
        filter.Shiny = ShinyCheck.Checked;
        filter.Square = SquareCheck.Checked;
        filter.IVBin = ivbin;
        filter.IVVals = ivvals;
        filter.IVComps = ivcomps;
        filter.RewardItems = CheckRewards.Checked
            ? Rewards.Text
                .Split(',')
                .Where(z => int.TryParse(z.Trim(), out _))
                .Select(z => int.Parse(z.Trim()))
                .ToArray()
            : null;
        filter.RewardsCount = (int)RewardsCount.Value;
        filter.RewardsComp = RewardsComp.SelectedIndex;
        filter.BatchFilters = string.IsNullOrWhiteSpace(BatchFilters.Text) ? null : BatchFilters.Text.Split(Environment.NewLine);
        filter.Enabled = true;
        if (filter.IsFilterSet())
        {
            for (int i = 0; i < allFilters.Count; i++)
            {
                var f = allFilters[i];
                if (f.Name != filter.Name)
                    continue;
                allFilters.RemoveAt(i);
                break;
            }

            allFilters.Add(filter);
            ResetActiveFilters();
            ActiveFilters.SelectedIndex = ActiveFilters.Items.Count - 1;
        }
        else
        {
            MessageBox.Show("You have not set any stop conditions. No filter will be added.");
        }
    }

    private static int ToInt(bool b) => b ? 1 : 0;

    private void SpeciesCheck_CheckedChanged(object sender, EventArgs e)
    {
        Species.Enabled = SpeciesCheck.Checked;
    }

    private void Species_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Species.SelectedIndex == 206 || Species.SelectedIndex == 924)
        {
            RareVariant.Visible = true;
            Species.Size = new Size(90, 23);
        }
        else
        {
            RareVariant.Checked = false;
            RareVariant.Visible = false;
            Species.Size = new Size(178, 23);
        }
    }

    private void FormCheck_CheckedChanged(object sender, EventArgs e)
    {
        Form.Enabled = FormCheck.Checked;
    }

    private void NatureCheck_CheckedChanged(object sender, EventArgs e)
    {
        Nature.Enabled = NatureCheck.Checked;
    }

    private void StarCheck_CheckedChanged(object sender, EventArgs e)
    {
        Stars.Enabled = StarCheck.Checked;
        StarsComp.Enabled = StarCheck.Checked;
    }

    private void TeraCheck_CheckedChanged(object sender, EventArgs e)
    {
        TeraType.Enabled = TeraCheck.Checked;
    }

    private void GenderCheck_CheckedChanged(object sender, EventArgs e)
    {
        Gender.Enabled = GenderCheck.Checked;
    }

    private void SizeCheck_CheckedChanged(object sender, EventArgs e)
    {
        SizeBox.Enabled = SizeCheck.Checked;
    }

    private void HP_CheckedChanged(object sender, EventArgs e)
    {
        IVHP.Enabled = HP.Checked;
        HPComp.Enabled = HP.Checked;
    }

    private void Atk_CheckedChanged(object sender, EventArgs e)
    {
        IVATK.Enabled = Atk.Checked;
        AtkComp.Enabled = Atk.Checked;
    }

    private void Def_CheckedChanged(object sender, EventArgs e)
    {
        IVDEF.Enabled = Def.Checked;
        DefComp.Enabled = Def.Checked;
    }

    private void SpA_CheckedChanged(object sender, EventArgs e)
    {
        IVSPA.Enabled = SpA.Checked;
        SpaComp.Enabled = SpA.Checked;
    }

    private void SpD_CheckedChanged(object sender, EventArgs e)
    {
        IVSPD.Enabled = SpD.Checked;
        SpdComp.Enabled = SpD.Checked;
    }

    private void Spe_CheckedChanged(object sender, EventArgs e)
    {
        IVSPE.Enabled = Spe.Checked;
        SpeComp.Enabled = Spe.Checked;
    }

    private void FilterSettings_FormClosing(object sender, EventArgs e)
    {
        string output = JsonSerializer.Serialize(allFilters);
        using StreamWriter sw =
            new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "filters.json"));
        sw.Write(output);
    }

    private void Remove_Click(object sender, EventArgs e)
    {
        if (ActiveFilters.Items.Count == 0 || ActiveFilters.SelectedIndex == -1)
            return;

        var idx = ActiveFilters.SelectedIndex;
        displayFilters.RemoveAt(idx);
        ResetActiveFilters();
    }

    private void ActiveFilters_SelectedIndexChanged(object sender, EventArgs e)
    {
        RefreshSelectedFilter();
    }

    private void RefreshSelectedFilter()
    {
        Remove.Enabled = ActiveFilters.SelectedIndex >= 0;
        if (ActiveFilters.SelectedIndex < 0)
            return;
        SelectFilter(displayFilters[ActiveFilters.SelectedIndex]);
    }

    private void ActiveFilters_ItemCheck(object sender, ItemCheckEventArgs e)
    {
        displayFilters[e.Index].Enabled = e.NewValue == CheckState.Checked;
    }

    private void FilterName_TextChanged(object sender, EventArgs e)
    {
        if (allFilters.Any(filter => filter.Name == FilterName.Text))
            Add.Text = "Update Filter";
        else
            Add.Text = "Add Filter";
    }

    private void CheckRewards_CheckedChanged(object sender, EventArgs e)
    {
        Rewards.Enabled = CheckRewards.Checked;
        ButtonOpenRewardsList.Enabled = CheckRewards.Checked;
        RewardsComp.Enabled = CheckRewards.Checked;
        RewardsCount.Enabled = CheckRewards.Checked;
    }

    private void ButtonOpenRewardsList_Click(object sender, EventArgs e)
    {
        List<int> IDs = Rewards.Text.Split(',').Select(int.Parse).ToList();
        using ItemIDs form = new(IDs);
        if (form.ShowDialog() != DialogResult.OK)
            return;
        List<int> s = new();
        if (form.CheckAbilityCapsule.Checked)
            s.Add(645);
        if (form.CheckBottleCap.Checked)
            s.Add(795);
        if (form.CheckAbilityPatch.Checked)
            s.Add(1606);
        if (form.CheckSweet.Checked)
            s.Add(1904);
        if (form.CheckSalty.Checked)
            s.Add(1905);
        if (form.CheckSour.Checked)
            s.Add(1906);
        if (form.CheckBitter.Checked)
            s.Add(1907);
        if (form.CheckSpicy.Checked)
            s.Add(1908);

        Rewards.Text = string.Join(",", s);
    }

    private void ActiveFilters_DrawItem(object sender, DrawItemEventArgs e)
    {
        e.DrawBackground();

        ListBox lb = (ListBox)sender;
        Graphics g = e.Graphics;
        RaidFilter filter = (RaidFilter)lb.Items[e.Index];

        var highlight = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
        var color = highlight ? ColorTranslator.FromHtml("#000078d7") : Color.White;
        var brush = new SolidBrush(color);
        g.FillRectangle(brush, e.Bounds);

        var textColor = filter.Enabled ? e.ForeColor : Color.Gray;
        var textBrush = new SolidBrush(textColor);
        var pt = new PointF(e.Bounds.X, e.Bounds.Y);
        g.DrawString(filter.Name, new Font(Name = "Segoe UI", 9), textBrush, pt);

        e.DrawFocusRectangle();
    }

    private void SquareCheck_CheckedChanged(object sender, EventArgs e)
    {
        if (SquareCheck.Checked) { ShinyCheck.Enabled = false; ShinyCheck.Checked = false; }
        else { ShinyCheck.Enabled = true; }
    }

    private void SearchBar_TextChanged(object sender, EventArgs e)
    {
        SearchBar.BackColor = (SearchBar.Text.Length > 0) ? SearchActiveColor : SearchInactiveColor;
        ResetActiveFilters();
        RefreshSelectedFilter();
    }
}

public class RaidFilterCollection : IEnumerable<RaidFilter>
{
    private readonly List<RaidFilter> originalList;
    private readonly TextBox SearchBar;
    private readonly Func<RaidFilter, bool> filterPredicate;

    public RaidFilterCollection(ref List<RaidFilter> originalList, TextBox searchBar)
    {
        this.originalList = originalList;
        SearchBar = searchBar;
        filterPredicate = filter => Regex.IsMatch(filter.Name ?? "", SearchBar.Text, RegexOptions.IgnoreCase);
    }

    public IEnumerator<RaidFilter> GetEnumerator()
    {
        try
        {
            return originalList.Where(filterPredicate).GetEnumerator();
        }
        catch (ArgumentException)
        {
            return null;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count
    {
        get
        {
            try
            {
                return originalList.Count(filterPredicate);
            }
            catch (ArgumentException)
            {
                return 0;
            }
        }
    }

    public bool Add(RaidFilter item)
    {
        originalList.Add(item);
        return true;
    }

    public bool Remove(RaidFilter item)
    {
        return originalList.Remove(item);
    }

    public void RemoveAt(int index)
    {
        if (index < this.Count())
        {
            Remove(this[index]);
        }
    }

    public RaidFilter this[int index]
    {
        get
        {
            try
            {
                return originalList.Where(filterPredicate).ElementAt(index);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
    }
}
