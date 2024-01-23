namespace RaidCrawler.WinForms.SubForms
{
    partial class FilterSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Species = new ComboBox();
            SpeciesCheck = new CheckBox();
            Form = new NumericUpDown();
            FormCheck = new CheckBox();
            NatureCheck = new CheckBox();
            Nature = new ComboBox();
            StarCheck = new CheckBox();
            Stars = new ComboBox();
            ShinyCheck = new CheckBox();
            Add = new Button();
            PerfectIVFilterGroup = new GroupBox();
            SpeComp = new ComboBox();
            SpaComp = new ComboBox();
            SpdComp = new ComboBox();
            DefComp = new ComboBox();
            AtkComp = new ComboBox();
            HPComp = new ComboBox();
            IVSPE = new NumericUpDown();
            IVSPD = new NumericUpDown();
            IVSPA = new NumericUpDown();
            IVDEF = new NumericUpDown();
            IVATK = new NumericUpDown();
            IVHP = new NumericUpDown();
            Spe = new CheckBox();
            SpD = new CheckBox();
            SpA = new CheckBox();
            Def = new CheckBox();
            Atk = new CheckBox();
            HP = new CheckBox();
            TeraCheck = new CheckBox();
            TeraType = new ComboBox();
            ActiveFilters = new CheckedListBox();
            FilterName = new TextBox();
            label1 = new Label();
            Remove = new Button();
            StarsComp = new ComboBox();
            RewardsComp = new ComboBox();
            CheckRewards = new CheckBox();
            Rewards = new TextBox();
            label2 = new Label();
            RewardsCount = new NumericUpDown();
            ButtonOpenRewardsList = new Button();
            GenderCheck = new CheckBox();
            Gender = new ComboBox();
            LabelBatchFilters = new Label();
            BatchFilters = new TextBox();
            SquareCheck = new CheckBox();
            Tooltip = new ToolTip(components);
            SizeBox = new ComboBox();
            SizeCheck = new CheckBox();
            RareVariant = new CheckBox();
            SearchBarLabel = new Label();
            SearchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Form).BeginInit();
            PerfectIVFilterGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IVSPE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IVSPD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IVSPA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IVDEF).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IVATK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IVHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RewardsCount).BeginInit();
            SuspendLayout();
            // 
            // Species
            // 
            Species.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Species.AutoCompleteSource = AutoCompleteSource.ListItems;
            Species.Enabled = false;
            Species.FormattingEnabled = true;
            Species.Location = new Point(104, 55);
            Species.Name = "Species";
            Species.Size = new Size(90, 23);
            Species.TabIndex = 0;
            Species.SelectedIndexChanged += Species_SelectedIndexChanged;
            // 
            // SpeciesCheck
            // 
            SpeciesCheck.AutoSize = true;
            SpeciesCheck.Location = new Point(15, 57);
            SpeciesCheck.Name = "SpeciesCheck";
            SpeciesCheck.Size = new Size(65, 19);
            SpeciesCheck.TabIndex = 1;
            SpeciesCheck.Text = "Species";
            SpeciesCheck.UseVisualStyleBackColor = true;
            SpeciesCheck.CheckedChanged += SpeciesCheck_CheckedChanged;
            // 
            // Form
            // 
            Form.Enabled = false;
            Form.Location = new Point(104, 82);
            Form.Name = "Form";
            Form.Size = new Size(178, 23);
            Form.TabIndex = 0;
            // 
            // FormCheck
            // 
            FormCheck.AutoSize = true;
            FormCheck.Location = new Point(15, 84);
            FormCheck.Name = "FormCheck";
            FormCheck.Size = new Size(54, 19);
            FormCheck.TabIndex = 1;
            FormCheck.Text = "Form";
            FormCheck.UseVisualStyleBackColor = true;
            FormCheck.CheckedChanged += FormCheck_CheckedChanged;
            // 
            // NatureCheck
            // 
            NatureCheck.AutoSize = true;
            NatureCheck.Location = new Point(15, 113);
            NatureCheck.Name = "NatureCheck";
            NatureCheck.Size = new Size(62, 19);
            NatureCheck.TabIndex = 3;
            NatureCheck.Text = "Nature";
            NatureCheck.UseVisualStyleBackColor = true;
            NatureCheck.CheckedChanged += NatureCheck_CheckedChanged;
            // 
            // Nature
            // 
            Nature.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Nature.AutoCompleteSource = AutoCompleteSource.ListItems;
            Nature.Enabled = false;
            Nature.FormattingEnabled = true;
            Nature.Location = new Point(104, 111);
            Nature.Name = "Nature";
            Nature.Size = new Size(178, 23);
            Nature.TabIndex = 2;
            // 
            // StarCheck
            // 
            StarCheck.AutoSize = true;
            StarCheck.Location = new Point(15, 142);
            StarCheck.Name = "StarCheck";
            StarCheck.Size = new Size(51, 19);
            StarCheck.TabIndex = 5;
            StarCheck.Text = "Stars";
            StarCheck.UseVisualStyleBackColor = true;
            StarCheck.CheckedChanged += StarCheck_CheckedChanged;
            // 
            // Stars
            // 
            Stars.Enabled = false;
            Stars.FormattingEnabled = true;
            Stars.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            Stars.Location = new Point(104, 140);
            Stars.Name = "Stars";
            Stars.Size = new Size(119, 23);
            Stars.TabIndex = 4;
            // 
            // ShinyCheck
            // 
            ShinyCheck.AutoSize = true;
            ShinyCheck.Location = new Point(15, 314);
            ShinyCheck.Name = "ShinyCheck";
            ShinyCheck.Size = new Size(55, 19);
            ShinyCheck.TabIndex = 6;
            ShinyCheck.Text = "Shiny";
            ShinyCheck.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(12, 469);
            Add.Name = "Add";
            Add.Size = new Size(132, 23);
            Add.TabIndex = 9;
            Add.Text = "Add Filter";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Filter_Click;
            // 
            // PerfectIVFilterGroup
            // 
            PerfectIVFilterGroup.Controls.Add(SpeComp);
            PerfectIVFilterGroup.Controls.Add(SpaComp);
            PerfectIVFilterGroup.Controls.Add(SpdComp);
            PerfectIVFilterGroup.Controls.Add(DefComp);
            PerfectIVFilterGroup.Controls.Add(AtkComp);
            PerfectIVFilterGroup.Controls.Add(HPComp);
            PerfectIVFilterGroup.Controls.Add(IVSPE);
            PerfectIVFilterGroup.Controls.Add(IVSPD);
            PerfectIVFilterGroup.Controls.Add(IVSPA);
            PerfectIVFilterGroup.Controls.Add(IVDEF);
            PerfectIVFilterGroup.Controls.Add(IVATK);
            PerfectIVFilterGroup.Controls.Add(IVHP);
            PerfectIVFilterGroup.Controls.Add(Spe);
            PerfectIVFilterGroup.Controls.Add(SpD);
            PerfectIVFilterGroup.Controls.Add(SpA);
            PerfectIVFilterGroup.Controls.Add(Def);
            PerfectIVFilterGroup.Controls.Add(Atk);
            PerfectIVFilterGroup.Controls.Add(HP);
            PerfectIVFilterGroup.Location = new Point(12, 339);
            PerfectIVFilterGroup.Name = "PerfectIVFilterGroup";
            PerfectIVFilterGroup.Size = new Size(270, 124);
            PerfectIVFilterGroup.TabIndex = 10;
            PerfectIVFilterGroup.TabStop = false;
            PerfectIVFilterGroup.Text = "IV Filters";
            // 
            // SpeComp
            // 
            SpeComp.DropDownStyle = ComboBoxStyle.DropDownList;
            SpeComp.Enabled = false;
            SpeComp.FormattingEnabled = true;
            SpeComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            SpeComp.Location = new Point(228, 54);
            SpeComp.Name = "SpeComp";
            SpeComp.Size = new Size(39, 23);
            SpeComp.TabIndex = 17;
            // 
            // SpaComp
            // 
            SpaComp.DropDownStyle = ComboBoxStyle.DropDownList;
            SpaComp.Enabled = false;
            SpaComp.FormattingEnabled = true;
            SpaComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            SpaComp.Location = new Point(138, 54);
            SpaComp.Name = "SpaComp";
            SpaComp.Size = new Size(39, 23);
            SpaComp.TabIndex = 15;
            // 
            // SpdComp
            // 
            SpdComp.DropDownStyle = ComboBoxStyle.DropDownList;
            SpdComp.Enabled = false;
            SpdComp.FormattingEnabled = true;
            SpdComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            SpdComp.Location = new Point(183, 54);
            SpdComp.Name = "SpdComp";
            SpdComp.Size = new Size(39, 23);
            SpdComp.TabIndex = 16;
            // 
            // DefComp
            // 
            DefComp.DropDownStyle = ComboBoxStyle.DropDownList;
            DefComp.Enabled = false;
            DefComp.FormattingEnabled = true;
            DefComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            DefComp.Location = new Point(93, 54);
            DefComp.Name = "DefComp";
            DefComp.Size = new Size(39, 23);
            DefComp.TabIndex = 14;
            // 
            // AtkComp
            // 
            AtkComp.DropDownStyle = ComboBoxStyle.DropDownList;
            AtkComp.Enabled = false;
            AtkComp.FormattingEnabled = true;
            AtkComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            AtkComp.Location = new Point(48, 54);
            AtkComp.Name = "AtkComp";
            AtkComp.Size = new Size(39, 23);
            AtkComp.TabIndex = 13;
            // 
            // HPComp
            // 
            HPComp.DropDownStyle = ComboBoxStyle.DropDownList;
            HPComp.Enabled = false;
            HPComp.FormattingEnabled = true;
            HPComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            HPComp.Location = new Point(3, 54);
            HPComp.Name = "HPComp";
            HPComp.Size = new Size(39, 23);
            HPComp.TabIndex = 12;
            // 
            // IVSPE
            // 
            IVSPE.Enabled = false;
            IVSPE.Location = new Point(228, 22);
            IVSPE.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            IVSPE.Name = "IVSPE";
            IVSPE.Size = new Size(39, 23);
            IVSPE.TabIndex = 11;
            IVSPE.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // IVSPD
            // 
            IVSPD.Enabled = false;
            IVSPD.Location = new Point(183, 22);
            IVSPD.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            IVSPD.Name = "IVSPD";
            IVSPD.Size = new Size(39, 23);
            IVSPD.TabIndex = 10;
            IVSPD.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // IVSPA
            // 
            IVSPA.Enabled = false;
            IVSPA.Location = new Point(138, 22);
            IVSPA.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            IVSPA.Name = "IVSPA";
            IVSPA.Size = new Size(39, 23);
            IVSPA.TabIndex = 9;
            IVSPA.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // IVDEF
            // 
            IVDEF.Enabled = false;
            IVDEF.Location = new Point(93, 22);
            IVDEF.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            IVDEF.Name = "IVDEF";
            IVDEF.Size = new Size(39, 23);
            IVDEF.TabIndex = 8;
            IVDEF.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // IVATK
            // 
            IVATK.Enabled = false;
            IVATK.Location = new Point(48, 22);
            IVATK.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            IVATK.Name = "IVATK";
            IVATK.Size = new Size(39, 23);
            IVATK.TabIndex = 7;
            IVATK.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // IVHP
            // 
            IVHP.Enabled = false;
            IVHP.Location = new Point(3, 22);
            IVHP.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            IVHP.Name = "IVHP";
            IVHP.Size = new Size(39, 23);
            IVHP.TabIndex = 6;
            IVHP.Value = new decimal(new int[] { 31, 0, 0, 0 });
            // 
            // Spe
            // 
            Spe.AutoSize = true;
            Spe.CheckAlign = ContentAlignment.TopCenter;
            Spe.Location = new Point(233, 83);
            Spe.Name = "Spe";
            Spe.Size = new Size(30, 33);
            Spe.TabIndex = 5;
            Spe.Text = "Spe";
            Spe.TextAlign = ContentAlignment.MiddleCenter;
            Spe.UseVisualStyleBackColor = true;
            Spe.CheckedChanged += Spe_CheckedChanged;
            // 
            // SpD
            // 
            SpD.AutoSize = true;
            SpD.CheckAlign = ContentAlignment.TopCenter;
            SpD.Location = new Point(187, 83);
            SpD.Name = "SpD";
            SpD.Size = new Size(32, 33);
            SpD.TabIndex = 4;
            SpD.Text = "SpD";
            SpD.TextAlign = ContentAlignment.MiddleCenter;
            SpD.UseVisualStyleBackColor = true;
            SpD.CheckedChanged += SpD_CheckedChanged;
            // 
            // SpA
            // 
            SpA.AutoSize = true;
            SpA.CheckAlign = ContentAlignment.TopCenter;
            SpA.Location = new Point(142, 83);
            SpA.Name = "SpA";
            SpA.Size = new Size(32, 33);
            SpA.TabIndex = 3;
            SpA.Text = "SpA";
            SpA.TextAlign = ContentAlignment.MiddleCenter;
            SpA.UseVisualStyleBackColor = true;
            SpA.CheckedChanged += SpA_CheckedChanged;
            // 
            // Def
            // 
            Def.AutoSize = true;
            Def.CheckAlign = ContentAlignment.TopCenter;
            Def.Location = new Point(99, 83);
            Def.Name = "Def";
            Def.Size = new Size(29, 33);
            Def.TabIndex = 2;
            Def.Text = "Def";
            Def.TextAlign = ContentAlignment.MiddleCenter;
            Def.UseVisualStyleBackColor = true;
            Def.CheckedChanged += Def_CheckedChanged;
            // 
            // Atk
            // 
            Atk.AutoSize = true;
            Atk.CheckAlign = ContentAlignment.TopCenter;
            Atk.Location = new Point(54, 84);
            Atk.Name = "Atk";
            Atk.Size = new Size(29, 33);
            Atk.TabIndex = 1;
            Atk.Text = "Atk";
            Atk.TextAlign = ContentAlignment.MiddleCenter;
            Atk.UseVisualStyleBackColor = true;
            Atk.CheckedChanged += Atk_CheckedChanged;
            // 
            // HP
            // 
            HP.AutoSize = true;
            HP.CheckAlign = ContentAlignment.TopCenter;
            HP.Location = new Point(10, 84);
            HP.Name = "HP";
            HP.Size = new Size(27, 33);
            HP.TabIndex = 0;
            HP.Text = "HP";
            HP.TextAlign = ContentAlignment.MiddleCenter;
            HP.UseVisualStyleBackColor = true;
            HP.CheckedChanged += HP_CheckedChanged;
            // 
            // TeraCheck
            // 
            TeraCheck.AutoSize = true;
            TeraCheck.Location = new Point(15, 171);
            TeraCheck.Name = "TeraCheck";
            TeraCheck.Size = new Size(74, 19);
            TeraCheck.TabIndex = 18;
            TeraCheck.Text = "Tera Type";
            TeraCheck.UseVisualStyleBackColor = true;
            TeraCheck.CheckedChanged += TeraCheck_CheckedChanged;
            // 
            // TeraType
            // 
            TeraType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TeraType.AutoCompleteSource = AutoCompleteSource.ListItems;
            TeraType.Enabled = false;
            TeraType.FormattingEnabled = true;
            TeraType.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7" });
            TeraType.Location = new Point(104, 169);
            TeraType.Name = "TeraType";
            TeraType.Size = new Size(178, 23);
            TeraType.TabIndex = 17;
            //
            // SearchBarLabel
            //
            SearchBarLabel.AutoSize = true;
            SearchBarLabel.Location = new Point(305, 26);
            SearchBarLabel.Name = "SearchBarLabel";
            SearchBarLabel.Size = new Size(50, 15);
            SearchBarLabel.TabIndex = 40;
            SearchBarLabel.Text = "Search:";
            //
            // SearchBar
            //
            SearchBar.BorderStyle = BorderStyle.FixedSingle;
            SearchBar.Location = new Point(361, 23);
            SearchBar.Name = "SearchBar";
            SearchBar.Size = new Size(129, 23);
            SearchBar.TabIndex = 41;
            SearchBar.TextChanged += SearchBar_TextChanged;
            // 
            // ActiveFilters
            // 
            ActiveFilters.FormattingEnabled = true;
            ActiveFilters.Location = new Point(305, 48);
            ActiveFilters.Name = "ActiveFilters";
            ActiveFilters.Size = new Size(185, 249);
            ActiveFilters.TabIndex = 20;
            ActiveFilters.ItemCheck += ActiveFilters_ItemCheck;
            ActiveFilters.DrawItem += ActiveFilters_DrawItem;
            ActiveFilters.SelectedIndexChanged += ActiveFilters_SelectedIndexChanged;
            // 
            // FilterName
            // 
            FilterName.BorderStyle = BorderStyle.FixedSingle;
            FilterName.Location = new Point(57, 23);
            FilterName.Name = "FilterName";
            FilterName.Size = new Size(225, 23);
            FilterName.TabIndex = 21;
            FilterName.TextChanged += FilterName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 22;
            label1.Text = "Name";
            // 
            // Remove
            // 
            Remove.Location = new Point(150, 468);
            Remove.Name = "Remove";
            Remove.Size = new Size(132, 23);
            Remove.TabIndex = 23;
            Remove.Text = "Remove Filter";
            Remove.UseVisualStyleBackColor = true;
            Remove.Click += Remove_Click;
            // 
            // StarsComp
            // 
            StarsComp.DropDownStyle = ComboBoxStyle.DropDownList;
            StarsComp.Enabled = false;
            StarsComp.FormattingEnabled = true;
            StarsComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            StarsComp.Location = new Point(229, 140);
            StarsComp.Name = "StarsComp";
            StarsComp.Size = new Size(53, 23);
            StarsComp.TabIndex = 18;
            // 
            // RewardsComp
            // 
            RewardsComp.DropDownStyle = ComboBoxStyle.DropDownList;
            RewardsComp.Enabled = false;
            RewardsComp.FormattingEnabled = true;
            RewardsComp.IntegralHeight = false;
            RewardsComp.Items.AddRange(new object[] { "=", ">", ">=", "<=", "<" });
            RewardsComp.Location = new Point(229, 285);
            RewardsComp.Name = "RewardsComp";
            RewardsComp.Size = new Size(53, 23);
            RewardsComp.TabIndex = 27;
            // 
            // CheckRewards
            // 
            CheckRewards.AutoSize = true;
            CheckRewards.Location = new Point(15, 258);
            CheckRewards.Name = "CheckRewards";
            CheckRewards.Size = new Size(70, 19);
            CheckRewards.TabIndex = 26;
            CheckRewards.Text = "Rewards";
            CheckRewards.UseVisualStyleBackColor = true;
            CheckRewards.CheckedChanged += CheckRewards_CheckedChanged;
            // 
            // Rewards
            // 
            Rewards.Enabled = false;
            Rewards.Location = new Point(104, 256);
            Rewards.Name = "Rewards";
            Rewards.Size = new Size(153, 23);
            Rewards.TabIndex = 28;
            Rewards.Text = "645,795,1606,1904,1905,1906,1907,1908";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 288);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 29;
            label2.Text = "Reward Count";
            // 
            // RewardsCount
            // 
            RewardsCount.Enabled = false;
            RewardsCount.Location = new Point(104, 285);
            RewardsCount.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            RewardsCount.Name = "RewardsCount";
            RewardsCount.Size = new Size(119, 23);
            RewardsCount.TabIndex = 30;
            // 
            // ButtonOpenRewardsList
            // 
            ButtonOpenRewardsList.Location = new Point(263, 256);
            ButtonOpenRewardsList.Name = "ButtonOpenRewardsList";
            ButtonOpenRewardsList.Size = new Size(19, 23);
            ButtonOpenRewardsList.TabIndex = 31;
            ButtonOpenRewardsList.Text = "?";
            ButtonOpenRewardsList.UseVisualStyleBackColor = true;
            ButtonOpenRewardsList.Click += ButtonOpenRewardsList_Click;
            // 
            // GenderCheck
            // 
            GenderCheck.AutoSize = true;
            GenderCheck.Location = new Point(15, 200);
            GenderCheck.Name = "GenderCheck";
            GenderCheck.Size = new Size(64, 19);
            GenderCheck.TabIndex = 33;
            GenderCheck.Text = "Gender";
            GenderCheck.UseVisualStyleBackColor = true;
            GenderCheck.CheckedChanged += GenderCheck_CheckedChanged;
            // 
            // Gender
            // 
            Gender.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Gender.AutoCompleteSource = AutoCompleteSource.ListItems;
            Gender.Enabled = false;
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female", "Genderless" });
            Gender.Location = new Point(104, 198);
            Gender.Name = "Gender";
            Gender.Size = new Size(178, 23);
            Gender.TabIndex = 32;
            // 
            // LabelBatchFilters
            // 
            LabelBatchFilters.AutoSize = true;
            LabelBatchFilters.Location = new Point(305, 315);
            LabelBatchFilters.Name = "LabelBatchFilters";
            LabelBatchFilters.Size = new Size(71, 15);
            LabelBatchFilters.TabIndex = 34;
            LabelBatchFilters.Text = "Batch Filters";
            // 
            // BatchFilters
            // 
            BatchFilters.BorderStyle = BorderStyle.FixedSingle;
            BatchFilters.Location = new Point(305, 335);
            BatchFilters.Multiline = true;
            BatchFilters.Name = "BatchFilters";
            BatchFilters.Size = new Size(185, 157);
            BatchFilters.TabIndex = 35;
            // 
            // SquareCheck
            // 
            SquareCheck.AutoSize = true;
            SquareCheck.Location = new Point(104, 314);
            SquareCheck.Name = "SquareCheck";
            SquareCheck.Size = new Size(62, 19);
            SquareCheck.TabIndex = 36;
            SquareCheck.Text = "Square";
            Tooltip.SetToolTip(SquareCheck, "If checked, only stop on \"Square\" shinies.\r\nThere is no display difference for these in SV, but they will appear\r\nas Square shiny in SwSh or any future game that supports them.");
            SquareCheck.UseVisualStyleBackColor = true;
            SquareCheck.CheckedChanged += SquareCheck_CheckedChanged;
            // 
            // SizeBox
            // 
            SizeBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            SizeBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            SizeBox.Enabled = false;
            SizeBox.FormattingEnabled = true;
            SizeBox.Items.AddRange(new object[] { "XXXS", "XXS", "XS", "S", "AV", "L", "XL", "XXL", "XXXL" });
            SizeBox.Location = new Point(104, 227);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(178, 23);
            SizeBox.TabIndex = 37;
            // 
            // SizeCheck
            // 
            SizeCheck.AutoSize = true;
            SizeCheck.Location = new Point(15, 229);
            SizeCheck.Name = "SizeCheck";
            SizeCheck.Size = new Size(46, 19);
            SizeCheck.TabIndex = 38;
            SizeCheck.Text = "Size";
            SizeCheck.UseVisualStyleBackColor = true;
            SizeCheck.CheckedChanged += SizeCheck_CheckedChanged;
            // 
            // RareVariant
            // 
            RareVariant.AutoSize = true;
            RareVariant.Location = new Point(200, 57);
            RareVariant.Name = "RareVariant";
            RareVariant.Size = new Size(88, 19);
            RareVariant.TabIndex = 39;
            RareVariant.Text = "Rare Variant";
            RareVariant.UseVisualStyleBackColor = true;
            RareVariant.Visible = false;
            // 
            // FilterSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 505);
            Controls.Add(RareVariant);
            Controls.Add(SizeCheck);
            Controls.Add(SizeBox);
            Controls.Add(SquareCheck);
            Controls.Add(BatchFilters);
            Controls.Add(LabelBatchFilters);
            Controls.Add(GenderCheck);
            Controls.Add(Gender);
            Controls.Add(ButtonOpenRewardsList);
            Controls.Add(RewardsCount);
            Controls.Add(label2);
            Controls.Add(Rewards);
            Controls.Add(RewardsComp);
            Controls.Add(CheckRewards);
            Controls.Add(StarsComp);
            Controls.Add(Remove);
            Controls.Add(label1);
            Controls.Add(FilterName);
            Controls.Add(SearchBarLabel);
            Controls.Add(SearchBar);
            Controls.Add(ActiveFilters);
            Controls.Add(TeraCheck);
            Controls.Add(TeraType);
            Controls.Add(PerfectIVFilterGroup);
            Controls.Add(Add);
            Controls.Add(ShinyCheck);
            Controls.Add(StarCheck);
            Controls.Add(Stars);
            Controls.Add(NatureCheck);
            Controls.Add(Nature);
            Controls.Add(FormCheck);
            Controls.Add(Form);
            Controls.Add(SpeciesCheck);
            Controls.Add(Species);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FilterSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FilterSettings";
            FormClosing += FilterSettings_FormClosing;
            ((System.ComponentModel.ISupportInitialize)Form).EndInit();
            PerfectIVFilterGroup.ResumeLayout(false);
            PerfectIVFilterGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IVSPE).EndInit();
            ((System.ComponentModel.ISupportInitialize)IVSPD).EndInit();
            ((System.ComponentModel.ISupportInitialize)IVSPA).EndInit();
            ((System.ComponentModel.ISupportInitialize)IVDEF).EndInit();
            ((System.ComponentModel.ISupportInitialize)IVATK).EndInit();
            ((System.ComponentModel.ISupportInitialize)IVHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)RewardsCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Species;
        private CheckBox SpeciesCheck;
        private NumericUpDown Form;
        private CheckBox FormCheck;
        private CheckBox NatureCheck;
        private ComboBox Nature;
        private CheckBox StarCheck;
        private ComboBox Stars;
        private CheckBox ShinyCheck;
        private Button Add;
        private GroupBox PerfectIVFilterGroup;
        private CheckBox Spe;
        private CheckBox SpD;
        private CheckBox SpA;
        private CheckBox Def;
        private CheckBox Atk;
        private CheckBox HP;
        private NumericUpDown IVSPE;
        private NumericUpDown IVSPD;
        private NumericUpDown IVSPA;
        private NumericUpDown IVDEF;
        private NumericUpDown IVATK;
        private NumericUpDown IVHP;
        private CheckBox TeraCheck;
        private ComboBox TeraType;
        private CheckedListBox ActiveFilters;
        private TextBox FilterName;
        private Label label1;
        private Button Remove;
        private ComboBox HPComp;
        private ComboBox SpeComp;
        private ComboBox SpaComp;
        private ComboBox SpdComp;
        private ComboBox DefComp;
        private ComboBox AtkComp;
        private ComboBox StarsComp;
        private ComboBox RewardsComp;
        private CheckBox CheckRewards;
        private TextBox Rewards;
        private Label label2;
        private NumericUpDown RewardsCount;
        private Button ButtonOpenRewardsList;
        private CheckBox GenderCheck;
        private ComboBox Gender;
        private Label LabelBatchFilters;
        private TextBox BatchFilters;
        private CheckBox SquareCheck;
        private ToolTip Tooltip;
        private ComboBox SizeBox;
        private CheckBox SizeCheck;
        private CheckBox RareVariant;
        private Label SearchBarLabel;
        private TextBox SearchBar;
    }
}
