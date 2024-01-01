using RaidCrawler.WinForms.CustomUI;

namespace RaidCrawler.WinForms
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            toolTip = new ToolTip(components);
            ButtonAdvanceDate = new Button();
            CheckEnableFilters = new CheckBox();
            ButtonDisconnect = new Button();
            ButtonConnect = new Button();
            InputSwitchIP = new TextBox();
            LabelSwitchIP = new Label();
            LabelLoadedRaids = new Label();
            ButtonNext = new Button();
            ButtonPrevious = new Button();
            ButtonReadRaids = new Button();
            ButtonViewRAM = new Button();
            ButtonResetTime = new Button();
            StopFilter = new Button();
            Sprite = new PictureBox();
            GemIcon = new PictureBox();
            ButtonDownloadEvents = new Button();
            ConfigSettings = new Button();
            Rewards = new Button();
            LabelSandwichBonus = new Label();
            RaidBoost = new ComboBox();
            ComboIndex = new ComboBox();
            SendScreenshot = new Button();
            SearchTimer = new System.Timers.Timer();
            btnOpenMap = new Button();
            groupBox1 = new GroupBox();
            ButtonScreenState = new Button();
            statusStrip1 = new StatusStrip();
            StatusLabel = new ToolStripStatusLabel();
            ToolStripStatusLabel = new ToolStripStatusLabel();
            Label_DayAdvance = new ToolStripStatusLabel();
            USB_Port_label = new Label();
            USB_Port_TB = new TextBox();
            StopAdvance_Button = new Button();
            statsPanel = new MyPanel();
            CopyAnnounce = new Button();
            shinyBox = new PictureBox();
            labelEvent = new RoundLabel();
            LabelScale = new RoundLabel();
            LabelNature = new RoundLabel();
            LabelTeraType = new RoundLabel();
            LabelArea = new RoundLabel();
            LabelMoves = new RoundLabel();
            LabelAbility = new RoundLabel();
            LabelIVs = new RoundLabel();
            LabelGender = new RoundLabel();
            LabelSpecies = new RoundLabel();
            LabelDifficulty = new RoundLabel();
            LabelPID = new RoundLabel();
            LabelEC = new RoundLabel();
            LabelSeed = new RoundLabel();
            Move4 = new TransparentTextBox();
            Area = new TransparentTextBox();
            Move2 = new TransparentTextBox();
            Scale = new TransparentTextBox();
            Nature = new TransparentTextBox();
            TeraType = new TransparentTextBox();
            Move3 = new TransparentTextBox();
            Move1 = new TransparentTextBox();
            Ability = new TransparentTextBox();
            IVs = new TransparentTextBox();
            Gender = new TransparentTextBox();
            Species = new TransparentTextBox();
            Difficulty = new TransparentTextBox();
            PID = new TransparentTextBox();
            EC = new TransparentTextBox();
            Seed = new TransparentTextBox();
            spacerPanel2 = new MyPanel();
            spacerPanel1 = new MyPanel();
            navigationPanel = new MyPanel();
            interfacePanel = new MyPanel();
            GameVersionImg = new PictureBox();
            Protocol_dropdown = new ComboBox();
            Protocol_label = new Label();
            extrasPanel = new MyPanel();
            Streak = new Label();
            TotalMiss = new Label();
            LabelShinyCount = new Label();
            DaySkipSuccessRate = new Label();
            SearchTime = new Label();
            FomoTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)Sprite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GemIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchTimer).BeginInit();
            groupBox1.SuspendLayout();
            statusStrip1.SuspendLayout();
            statsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shinyBox).BeginInit();
            navigationPanel.SuspendLayout();
            interfacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GameVersionImg).BeginInit();
            extrasPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonAdvanceDate
            // 
            ButtonAdvanceDate.Enabled = false;
            ButtonAdvanceDate.Location = new Point(56, 235);
            ButtonAdvanceDate.Margin = new Padding(4, 3, 4, 3);
            ButtonAdvanceDate.Name = "ButtonAdvanceDate";
            ButtonAdvanceDate.Size = new Size(100, 33);
            ButtonAdvanceDate.TabIndex = 81;
            ButtonAdvanceDate.Text = "Advance Date";
            toolTip.SetToolTip(ButtonAdvanceDate, "Advance Date performs one (1) time set.\r\n\r\nIf Stop Filters are defined, Advance Date\r\ncontinues advancing the date until a stop\r\nfilter has been hit.");
            ButtonAdvanceDate.UseVisualStyleBackColor = true;
            ButtonAdvanceDate.Click += ButtonAdvanceDate_Click;
            // 
            // CheckEnableFilters
            // 
            CheckEnableFilters.AutoSize = true;
            CheckEnableFilters.Checked = true;
            CheckEnableFilters.CheckState = CheckState.Checked;
            CheckEnableFilters.Location = new Point(114, 211);
            CheckEnableFilters.Name = "CheckEnableFilters";
            CheckEnableFilters.Size = new Size(95, 19);
            CheckEnableFilters.TabIndex = 119;
            CheckEnableFilters.Text = "Enable Filters";
            toolTip.SetToolTip(CheckEnableFilters, "Enable Filters enables or disables all filters\r\nentirely.\r\n\r\nEnabled - Advance Date will continue until\r\na match occurs from a filter.\r\n\r\nDisabled - Advance Date will only advance\r\none (1) day.");
            CheckEnableFilters.UseVisualStyleBackColor = true;
            CheckEnableFilters.Click += EnableFilters_Click;
            // 
            // ButtonDisconnect
            // 
            ButtonDisconnect.Enabled = false;
            ButtonDisconnect.Location = new Point(106, 59);
            ButtonDisconnect.Margin = new Padding(4, 3, 4, 3);
            ButtonDisconnect.Name = "ButtonDisconnect";
            ButtonDisconnect.Size = new Size(100, 33);
            ButtonDisconnect.TabIndex = 11;
            ButtonDisconnect.Text = "Disconnect";
            ButtonDisconnect.UseVisualStyleBackColor = true;
            ButtonDisconnect.Click += Disconnect_Click;
            // 
            // ButtonConnect
            // 
            ButtonConnect.Location = new Point(6, 59);
            ButtonConnect.Margin = new Padding(4, 3, 4, 3);
            ButtonConnect.Name = "ButtonConnect";
            ButtonConnect.Size = new Size(100, 33);
            ButtonConnect.TabIndex = 10;
            ButtonConnect.Text = "Connect";
            ButtonConnect.UseVisualStyleBackColor = true;
            ButtonConnect.Click += ButtonConnect_Click;
            // 
            // InputSwitchIP
            // 
            InputSwitchIP.Location = new Point(77, 6);
            InputSwitchIP.Margin = new Padding(4, 3, 4, 3);
            InputSwitchIP.Name = "InputSwitchIP";
            InputSwitchIP.Size = new Size(129, 23);
            InputSwitchIP.TabIndex = 8;
            InputSwitchIP.Text = "www.www.www.www";
            InputSwitchIP.TextChanged += InputSwitchIP_Changed;
            // 
            // LabelSwitchIP
            // 
            LabelSwitchIP.AutoSize = true;
            LabelSwitchIP.Location = new Point(6, 10);
            LabelSwitchIP.Margin = new Padding(4, 0, 4, 0);
            LabelSwitchIP.Name = "LabelSwitchIP";
            LabelSwitchIP.Size = new Size(58, 15);
            LabelSwitchIP.TabIndex = 6;
            LabelSwitchIP.Text = "Switch IP:";
            // 
            // LabelLoadedRaids
            // 
            LabelLoadedRaids.AutoSize = true;
            LabelLoadedRaids.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLoadedRaids.Location = new Point(3, 20);
            LabelLoadedRaids.Name = "LabelLoadedRaids";
            LabelLoadedRaids.Size = new Size(74, 15);
            LabelLoadedRaids.TabIndex = 12;
            LabelLoadedRaids.Text = "Met Filters: 0";
            // 
            // ButtonNext
            // 
            ButtonNext.Enabled = false;
            ButtonNext.Location = new Point(215, 3);
            ButtonNext.Name = "ButtonNext";
            ButtonNext.Size = new Size(33, 27);
            ButtonNext.TabIndex = 56;
            ButtonNext.Text = ">>";
            ButtonNext.UseVisualStyleBackColor = true;
            ButtonNext.Click += ButtonNext_Click;
            // 
            // ButtonPrevious
            // 
            ButtonPrevious.Enabled = false;
            ButtonPrevious.Location = new Point(3, 3);
            ButtonPrevious.Name = "ButtonPrevious";
            ButtonPrevious.Size = new Size(33, 27);
            ButtonPrevious.TabIndex = 55;
            ButtonPrevious.Text = "<<";
            ButtonPrevious.UseVisualStyleBackColor = true;
            ButtonPrevious.Click += ButtonPrevious_Click;
            // 
            // ButtonReadRaids
            // 
            ButtonReadRaids.Enabled = false;
            ButtonReadRaids.Location = new Point(9, 45);
            ButtonReadRaids.Margin = new Padding(4, 3, 4, 3);
            ButtonReadRaids.Name = "ButtonReadRaids";
            ButtonReadRaids.Size = new Size(90, 25);
            ButtonReadRaids.TabIndex = 80;
            ButtonReadRaids.Text = "Read Raids";
            ButtonReadRaids.UseVisualStyleBackColor = true;
            ButtonReadRaids.Click += ButtonReadRaids_Click;
            // 
            // ButtonViewRAM
            // 
            ButtonViewRAM.Enabled = false;
            ButtonViewRAM.Location = new Point(102, 45);
            ButtonViewRAM.Name = "ButtonViewRAM";
            ButtonViewRAM.Size = new Size(90, 25);
            ButtonViewRAM.TabIndex = 89;
            ButtonViewRAM.Text = "Dump Raid";
            ButtonViewRAM.UseVisualStyleBackColor = true;
            ButtonViewRAM.Click += ViewRAM_Click;
            // 
            // StopFilter
            // 
            StopFilter.Location = new Point(6, 208);
            StopFilter.Name = "StopFilter";
            StopFilter.Size = new Size(97, 23);
            StopFilter.TabIndex = 107;
            StopFilter.Text = "Edit Filters";
            StopFilter.UseVisualStyleBackColor = true;
            StopFilter.Click += StopFilter_Click;
            // 
            // Sprite
            // 
            Sprite.BackColor = Color.Transparent;
            Sprite.BorderStyle = BorderStyle.FixedSingle;
            Sprite.Location = new Point(279, 3);
            Sprite.Name = "Sprite";
            Sprite.Size = new Size(68, 56);
            Sprite.SizeMode = PictureBoxSizeMode.CenterImage;
            Sprite.TabIndex = 108;
            Sprite.TabStop = false;
            // 
            // GemIcon
            // 
            GemIcon.BackColor = Color.Transparent;
            GemIcon.BorderStyle = BorderStyle.FixedSingle;
            GemIcon.Location = new Point(233, 11);
            GemIcon.Name = "GemIcon";
            GemIcon.Size = new Size(40, 40);
            GemIcon.SizeMode = PictureBoxSizeMode.Zoom;
            GemIcon.TabIndex = 111;
            GemIcon.TabStop = false;
            // 
            // ButtonDownloadEvents
            // 
            ButtonDownloadEvents.Enabled = false;
            ButtonDownloadEvents.Location = new Point(102, 72);
            ButtonDownloadEvents.Name = "ButtonDownloadEvents";
            ButtonDownloadEvents.Size = new Size(90, 25);
            ButtonDownloadEvents.TabIndex = 112;
            ButtonDownloadEvents.Text = "Pull Events";
            ButtonDownloadEvents.UseVisualStyleBackColor = true;
            ButtonDownloadEvents.Click += DownloadEvents_Click;
            //
            // ButtonResetTime
            //
            ButtonResetTime.Enabled = false;
            ButtonResetTime.Location = new Point(9, 99);
            ButtonResetTime.Name = "ButtonResetTime";
            ButtonResetTime.Size = new Size(90, 25);
            ButtonResetTime.TabIndex = 130;
            ButtonResetTime.Text = "Reset Date";
            ButtonResetTime.UseVisualStyleBackColor = true;
            ButtonResetTime.Click += B_ResetTime_Click;
            // 
            // ConfigSettings
            // 
            ConfigSettings.Location = new Point(6, 411);
            ConfigSettings.Name = "ConfigSettings";
            ConfigSettings.Size = new Size(200, 33);
            ConfigSettings.TabIndex = 115;
            ConfigSettings.Text = "Open Settings";
            ConfigSettings.UseVisualStyleBackColor = true;
            ConfigSettings.Click += ConfigSettings_Click;
            // 
            // Rewards
            // 
            Rewards.Location = new Point(77, 301);
            Rewards.Name = "Rewards";
            Rewards.Size = new Size(72, 23);
            Rewards.TabIndex = 116;
            Rewards.Text = "Rewards";
            Rewards.UseVisualStyleBackColor = true;
            Rewards.Click += Rewards_Click;
            // 
            // LabelSandwichBonus
            // 
            LabelSandwichBonus.AutoSize = true;
            LabelSandwichBonus.Location = new Point(6, 188);
            LabelSandwichBonus.Name = "LabelSandwichBonus";
            LabelSandwichBonus.Size = new Size(120, 15);
            LabelSandwichBonus.TabIndex = 118;
            LabelSandwichBonus.Text = "Raid Sandwich Boost:";
            // 
            // RaidBoost
            // 
            RaidBoost.FormattingEnabled = true;
            RaidBoost.Items.AddRange(new object[] { "0", "1", "2", "3" });
            RaidBoost.Location = new Point(158, 183);
            RaidBoost.Name = "RaidBoost";
            RaidBoost.Size = new Size(48, 23);
            RaidBoost.TabIndex = 117;
            RaidBoost.Text = "w";
            RaidBoost.SelectedIndexChanged += RaidBoost_SelectedIndexChanged;
            // 
            // ComboIndex
            // 
            ComboIndex.BackColor = SystemColors.Window;
            ComboIndex.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboIndex.Enabled = false;
            ComboIndex.FormattingEnabled = true;
            ComboIndex.Location = new Point(38, 5);
            ComboIndex.Name = "ComboIndex";
            ComboIndex.Size = new Size(175, 23);
            ComboIndex.TabIndex = 120;
            ComboIndex.SelectedIndexChanged += ComboIndex_SelectedIndexChanged;
            // 
            // SendScreenshot
            // 
            SendScreenshot.Location = new Point(102, 18);
            SendScreenshot.Name = "SendScreenshot";
            SendScreenshot.Size = new Size(90, 25);
            SendScreenshot.TabIndex = 121;
            SendScreenshot.Text = "Screenshot";
            SendScreenshot.UseVisualStyleBackColor = true;
            SendScreenshot.Click += SendScreenshot_Click;
            // 
            // SearchTimer
            // 
            SearchTimer.Enabled = false;
            SearchTimer.Interval = 1D;
            SearchTimer.SynchronizingObject = this;
            SearchTimer.Elapsed += SearchTimer_Elapsed;
            // 
            // btnOpenMap
            // 
            btnOpenMap.Location = new Point(9, 72);
            btnOpenMap.Name = "btnOpenMap";
            btnOpenMap.Size = new Size(90, 25);
            btnOpenMap.TabIndex = 124;
            btnOpenMap.Text = "Open Map";
            btnOpenMap.UseVisualStyleBackColor = true;
            btnOpenMap.Click += DisplayMap;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ButtonScreenState);
            groupBox1.Controls.Add(ButtonViewRAM);
            groupBox1.Controls.Add(ButtonDownloadEvents);
            groupBox1.Controls.Add(btnOpenMap);
            groupBox1.Controls.Add(SendScreenshot);
            groupBox1.Controls.Add(ButtonReadRaids);
            groupBox1.Controls.Add(ButtonResetTime);
            groupBox1.Location = new Point(6, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 131);
            groupBox1.TabIndex = 125;
            groupBox1.TabStop = false;
            groupBox1.Text = "Raid Controls";
            // 
            // ButtonScreenState
            // 
            ButtonScreenState.Location = new Point(9, 18);
            ButtonScreenState.Name = "ButtonScreenState";
            ButtonScreenState.Size = new Size(90, 25);
            ButtonScreenState.TabIndex = 138;
            ButtonScreenState.Text = "Screen Off";
            ButtonScreenState.UseVisualStyleBackColor = true;
            ButtonScreenState.Click += ButtonScreenState_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusLabel, ToolStripStatusLabel, Label_DayAdvance });
            statusStrip1.Location = new Point(0, 430);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(578, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 126;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 17);
            StatusLabel.Text = "Status:";
            // 
            // ToolStripStatusLabel
            // 
            ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            ToolStripStatusLabel.Size = new Size(89, 17);
            ToolStripStatusLabel.Text = "Not connected.";
            // 
            // Label_DayAdvance
            // 
            Label_DayAdvance.Name = "Label_DayAdvance";
            Label_DayAdvance.Size = new Size(0, 17);
            Label_DayAdvance.Visible = false;
            // 
            // USB_Port_label
            // 
            USB_Port_label.AutoSize = true;
            USB_Port_label.Location = new Point(6, 10);
            USB_Port_label.Name = "USB_Port_label";
            USB_Port_label.Size = new Size(56, 15);
            USB_Port_label.TabIndex = 127;
            USB_Port_label.Text = "USB Port:";
            // 
            // USB_Port_TB
            // 
            USB_Port_TB.Location = new Point(77, 6);
            USB_Port_TB.Name = "USB_Port_TB";
            USB_Port_TB.Size = new Size(129, 23);
            USB_Port_TB.TabIndex = 128;
            USB_Port_TB.Text = "w";
            USB_Port_TB.TextAlign = HorizontalAlignment.Center;
            USB_Port_TB.TextChanged += USB_Port_Changed;
            // 
            // StopAdvance_Button
            // 
            StopAdvance_Button.Location = new Point(56, 235);
            StopAdvance_Button.Name = "StopAdvance_Button";
            StopAdvance_Button.Size = new Size(100, 33);
            StopAdvance_Button.TabIndex = 129;
            StopAdvance_Button.Text = "Stop";
            StopAdvance_Button.UseVisualStyleBackColor = true;
            StopAdvance_Button.Visible = false;
            StopAdvance_Button.Click += StopAdvanceButton_Click;
            // 
            // statsPanel
            // 
            statsPanel.BackgroundImageLayout = ImageLayout.Stretch;
            statsPanel.border = Color.Gainsboro;
            statsPanel.Controls.Add(CopyAnnounce);
            statsPanel.Controls.Add(shinyBox);
            statsPanel.Controls.Add(labelEvent);
            statsPanel.Controls.Add(LabelScale);
            statsPanel.Controls.Add(LabelNature);
            statsPanel.Controls.Add(LabelTeraType);
            statsPanel.Controls.Add(Rewards);
            statsPanel.Controls.Add(LabelArea);
            statsPanel.Controls.Add(LabelMoves);
            statsPanel.Controls.Add(LabelAbility);
            statsPanel.Controls.Add(LabelIVs);
            statsPanel.Controls.Add(LabelGender);
            statsPanel.Controls.Add(LabelSpecies);
            statsPanel.Controls.Add(LabelDifficulty);
            statsPanel.Controls.Add(LabelPID);
            statsPanel.Controls.Add(LabelEC);
            statsPanel.Controls.Add(LabelSeed);
            statsPanel.Controls.Add(Move4);
            statsPanel.Controls.Add(Area);
            statsPanel.Controls.Add(Move2);
            statsPanel.Controls.Add(Scale);
            statsPanel.Controls.Add(Nature);
            statsPanel.Controls.Add(TeraType);
            statsPanel.Controls.Add(Move3);
            statsPanel.Controls.Add(Move1);
            statsPanel.Controls.Add(Ability);
            statsPanel.Controls.Add(IVs);
            statsPanel.Controls.Add(Gender);
            statsPanel.Controls.Add(Species);
            statsPanel.Controls.Add(Difficulty);
            statsPanel.Controls.Add(PID);
            statsPanel.Controls.Add(EC);
            statsPanel.Controls.Add(Seed);
            statsPanel.Controls.Add(Sprite);
            statsPanel.Controls.Add(GemIcon);
            statsPanel.Location = new Point(223, 37);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(350, 327);
            statsPanel.TabIndex = 130;
            // 
            // CopyAnnounce
            // 
            CopyAnnounce.Location = new Point(271, 301);
            CopyAnnounce.Name = "CopyAnnounce";
            CopyAnnounce.Size = new Size(76, 23);
            CopyAnnounce.TabIndex = 143;
            CopyAnnounce.Text = "Copy";
            CopyAnnounce.UseVisualStyleBackColor = true;
            CopyAnnounce.Click += CopyAnnounce_Click;
            // 
            // shinyBox
            // 
            shinyBox.BackColor = Color.Transparent;
            shinyBox.BackgroundImageLayout = ImageLayout.Center;
            shinyBox.Location = new Point(195, 15);
            shinyBox.Name = "shinyBox";
            shinyBox.Size = new Size(32, 32);
            shinyBox.TabIndex = 142;
            shinyBox.TabStop = false;
            // 
            // labelEvent
            // 
            labelEvent.AutoSize = true;
            labelEvent.backColor = Color.FromArgb(200, 30, 144, 255);
            labelEvent.BackColor = Color.Transparent;
            labelEvent.backColor2 = Color.FromArgb(5, 70, 125);
            labelEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelEvent.ForeColor = Color.White;
            labelEvent.Location = new Point(290, 65);
            labelEvent.Name = "labelEvent";
            labelEvent.Size = new Size(49, 15);
            labelEvent.TabIndex = 141;
            labelEvent.Text = "  Event  ";
            labelEvent.Visible = false;
            // 
            // LabelScale
            // 
            LabelScale.AutoSize = true;
            LabelScale.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelScale.BackColor = Color.Transparent;
            LabelScale.backColor2 = SystemColors.ButtonFace;
            LabelScale.Location = new Point(243, 197);
            LabelScale.Name = "LabelScale";
            LabelScale.Size = new Size(30, 15);
            LabelScale.TabIndex = 140;
            LabelScale.Text = "Size:";
            // 
            // LabelNature
            // 
            LabelNature.AutoSize = true;
            LabelNature.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelNature.BackColor = Color.Transparent;
            LabelNature.backColor2 = SystemColors.ButtonFace;
            LabelNature.Location = new Point(195, 143);
            LabelNature.Name = "LabelNature";
            LabelNature.Size = new Size(46, 15);
            LabelNature.TabIndex = 139;
            LabelNature.Text = "Nature:";
            // 
            // LabelTeraType
            // 
            LabelTeraType.AutoSize = true;
            LabelTeraType.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelTeraType.BackColor = Color.Transparent;
            LabelTeraType.backColor2 = SystemColors.ButtonFace;
            LabelTeraType.Location = new Point(183, 89);
            LabelTeraType.Name = "LabelTeraType";
            LabelTeraType.Size = new Size(58, 15);
            LabelTeraType.TabIndex = 138;
            LabelTeraType.Text = "Tera Type:";
            // 
            // LabelArea
            // 
            LabelArea.AutoSize = true;
            LabelArea.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelArea.BackColor = Color.Transparent;
            LabelArea.backColor2 = SystemColors.ButtonFace;
            LabelArea.Location = new Point(36, 278);
            LabelArea.Name = "LabelArea";
            LabelArea.Size = new Size(34, 15);
            LabelArea.TabIndex = 137;
            LabelArea.Text = "Area:";
            // 
            // LabelMoves
            // 
            LabelMoves.AutoSize = true;
            LabelMoves.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelMoves.BackColor = Color.Transparent;
            LabelMoves.backColor2 = SystemColors.ButtonFace;
            LabelMoves.Location = new Point(25, 236);
            LabelMoves.Name = "LabelMoves";
            LabelMoves.Size = new Size(45, 15);
            LabelMoves.TabIndex = 136;
            LabelMoves.Text = "Moves:";
            // 
            // LabelAbility
            // 
            LabelAbility.AutoSize = true;
            LabelAbility.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelAbility.BackColor = Color.Transparent;
            LabelAbility.backColor2 = SystemColors.ButtonFace;
            LabelAbility.Location = new Point(26, 197);
            LabelAbility.Name = "LabelAbility";
            LabelAbility.Size = new Size(44, 15);
            LabelAbility.TabIndex = 135;
            LabelAbility.Text = "Ability:";
            // 
            // LabelIVs
            // 
            LabelIVs.AutoSize = true;
            LabelIVs.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelIVs.BackColor = Color.Transparent;
            LabelIVs.backColor2 = SystemColors.ButtonFace;
            LabelIVs.Location = new Point(45, 170);
            LabelIVs.Name = "LabelIVs";
            LabelIVs.Size = new Size(25, 15);
            LabelIVs.TabIndex = 134;
            LabelIVs.Text = "IVs:";
            // 
            // LabelGender
            // 
            LabelGender.AutoSize = true;
            LabelGender.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelGender.BackColor = Color.Transparent;
            LabelGender.backColor2 = SystemColors.ButtonFace;
            LabelGender.Location = new Point(22, 143);
            LabelGender.Name = "LabelGender";
            LabelGender.Size = new Size(48, 15);
            LabelGender.TabIndex = 133;
            LabelGender.Text = "Gender:";
            // 
            // LabelSpecies
            // 
            LabelSpecies.AutoSize = true;
            LabelSpecies.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelSpecies.BackColor = Color.Transparent;
            LabelSpecies.backColor2 = SystemColors.ButtonFace;
            LabelSpecies.Location = new Point(21, 116);
            LabelSpecies.Name = "LabelSpecies";
            LabelSpecies.Size = new Size(49, 15);
            LabelSpecies.TabIndex = 132;
            LabelSpecies.Text = "Species:";
            // 
            // LabelDifficulty
            // 
            LabelDifficulty.AutoSize = true;
            LabelDifficulty.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelDifficulty.BackColor = Color.Transparent;
            LabelDifficulty.backColor2 = SystemColors.ButtonFace;
            LabelDifficulty.Location = new Point(12, 89);
            LabelDifficulty.Name = "LabelDifficulty";
            LabelDifficulty.Size = new Size(58, 15);
            LabelDifficulty.TabIndex = 131;
            LabelDifficulty.Text = "Difficulty:";
            // 
            // LabelPID
            // 
            LabelPID.AutoSize = true;
            LabelPID.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelPID.BackColor = Color.Transparent;
            LabelPID.backColor2 = SystemColors.ButtonFace;
            LabelPID.Location = new Point(42, 62);
            LabelPID.Name = "LabelPID";
            LabelPID.Size = new Size(28, 15);
            LabelPID.TabIndex = 130;
            LabelPID.Text = "PID:";
            // 
            // LabelEC
            // 
            LabelEC.AutoSize = true;
            LabelEC.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelEC.BackColor = Color.Transparent;
            LabelEC.backColor2 = SystemColors.ButtonFace;
            LabelEC.Location = new Point(46, 35);
            LabelEC.Name = "LabelEC";
            LabelEC.Size = new Size(24, 15);
            LabelEC.TabIndex = 129;
            LabelEC.Text = "EC:";
            // 
            // LabelSeed
            // 
            LabelSeed.AutoSize = true;
            LabelSeed.backColor = Color.FromArgb(125, 240, 240, 240);
            LabelSeed.BackColor = Color.Transparent;
            LabelSeed.backColor2 = SystemColors.ButtonFace;
            LabelSeed.Location = new Point(35, 8);
            LabelSeed.Name = "LabelSeed";
            LabelSeed.Size = new Size(35, 15);
            LabelSeed.TabIndex = 128;
            LabelSeed.Text = "Seed:";
            // 
            // Move4
            // 
            Move4.BackColor = Color.Transparent;
            Move4.Location = new Point(214, 247);
            Move4.Name = "Move4";
            Move4.Size = new Size(133, 23);
            Move4.TabIndex = 127;
            Move4.Click += Move_Clicked;
            // 
            // Area
            // 
            Area.BackColor = Color.Transparent;
            Area.Location = new Point(77, 274);
            Area.Name = "Area";
            Area.Size = new Size(270, 23);
            Area.TabIndex = 126;
            Area.Click += DisplayMap;
            // 
            // Move2
            // 
            Move2.BackColor = Color.Transparent;
            Move2.Location = new Point(214, 220);
            Move2.Name = "Move2";
            Move2.Size = new Size(133, 23);
            Move2.TabIndex = 125;
            Move2.Click += Move_Clicked;
            // 
            // Scale
            // 
            Scale.BackColor = Color.Transparent;
            Scale.Location = new Point(279, 193);
            Scale.Name = "Scale";
            Scale.Size = new Size(68, 23);
            Scale.TabIndex = 124;
            // 
            // Nature
            // 
            Nature.BackColor = Color.Transparent;
            Nature.Location = new Point(247, 139);
            Nature.Name = "Nature";
            Nature.Size = new Size(100, 23);
            Nature.TabIndex = 123;
            // 
            // TeraType
            // 
            TeraType.BackColor = Color.Transparent;
            TeraType.Location = new Point(247, 85);
            TeraType.Name = "TeraType";
            TeraType.Size = new Size(100, 23);
            TeraType.TabIndex = 122;
            // 
            // Move3
            // 
            Move3.BackColor = Color.Transparent;
            Move3.Location = new Point(77, 247);
            Move3.Name = "Move3";
            Move3.Size = new Size(133, 23);
            Move3.TabIndex = 121;
            Move3.Click += Move_Clicked;
            // 
            // Move1
            // 
            Move1.BackColor = Color.Transparent;
            Move1.Location = new Point(77, 220);
            Move1.Name = "Move1";
            Move1.Size = new Size(133, 23);
            Move1.TabIndex = 120;
            Move1.Click += Move_Clicked;
            // 
            // Ability
            // 
            Ability.BackColor = Color.Transparent;
            Ability.Location = new Point(77, 193);
            Ability.Name = "Ability";
            Ability.Size = new Size(133, 23);
            Ability.TabIndex = 119;
            // 
            // IVs
            // 
            IVs.BackColor = Color.Transparent;
            IVs.Location = new Point(77, 166);
            IVs.Name = "IVs";
            IVs.Size = new Size(270, 23);
            IVs.TabIndex = 118;
            // 
            // Gender
            // 
            Gender.BackColor = Color.Transparent;
            Gender.Location = new Point(77, 139);
            Gender.Name = "Gender";
            Gender.Size = new Size(100, 23);
            Gender.TabIndex = 117;
            // 
            // Species
            // 
            Species.BackColor = Color.Transparent;
            Species.Location = new Point(77, 112);
            Species.Name = "Species";
            Species.Size = new Size(270, 23);
            Species.TabIndex = 116;
            // 
            // Difficulty
            // 
            Difficulty.BackColor = Color.Transparent;
            Difficulty.Location = new Point(77, 85);
            Difficulty.Name = "Difficulty";
            Difficulty.Size = new Size(100, 23);
            Difficulty.TabIndex = 115;
            // 
            // PID
            // 
            PID.BackColor = Color.Transparent;
            PID.Location = new Point(77, 58);
            PID.Name = "PID";
            PID.Size = new Size(100, 23);
            PID.TabIndex = 114;
            PID.Click += Seed_Click;
            // 
            // EC
            // 
            EC.BackColor = Color.Transparent;
            EC.Location = new Point(77, 31);
            EC.Name = "EC";
            EC.Size = new Size(100, 23);
            EC.TabIndex = 113;
            EC.Click += Seed_Click;
            // 
            // Seed
            // 
            Seed.BackColor = Color.Transparent;
            Seed.Location = new Point(77, 4);
            Seed.Name = "Seed";
            Seed.Size = new Size(100, 23);
            Seed.TabIndex = 112;
            Seed.Click += Seed_Click;
            // 
            // spacerPanel2
            // 
            spacerPanel2.border = Color.Empty;
            spacerPanel2.Location = new Point(530, 2);
            spacerPanel2.Name = "spacerPanel2";
            spacerPanel2.Size = new Size(43, 33);
            spacerPanel2.TabIndex = 131;
            // 
            // spacerPanel1
            // 
            spacerPanel1.border = Color.Empty;
            spacerPanel1.Location = new Point(223, 2);
            spacerPanel1.Name = "spacerPanel1";
            spacerPanel1.Size = new Size(43, 33);
            spacerPanel1.TabIndex = 132;
            // 
            // navigationPanel
            // 
            navigationPanel.border = Color.Empty;
            navigationPanel.Controls.Add(ButtonNext);
            navigationPanel.Controls.Add(ButtonPrevious);
            navigationPanel.Controls.Add(ComboIndex);
            navigationPanel.Location = new Point(272, 2);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(252, 33);
            navigationPanel.TabIndex = 133;
            // 
            // interfacePanel
            // 
            interfacePanel.border = Color.Gainsboro;
            interfacePanel.Controls.Add(GameVersionImg);
            interfacePanel.Controls.Add(Protocol_dropdown);
            interfacePanel.Controls.Add(Protocol_label);
            interfacePanel.Controls.Add(ConfigSettings);
            interfacePanel.Controls.Add(USB_Port_TB);
            interfacePanel.Controls.Add(RaidBoost);
            interfacePanel.Controls.Add(LabelSandwichBonus);
            interfacePanel.Controls.Add(StopAdvance_Button);
            interfacePanel.Controls.Add(InputSwitchIP);
            interfacePanel.Controls.Add(CheckEnableFilters);
            interfacePanel.Controls.Add(groupBox1);
            interfacePanel.Controls.Add(LabelSwitchIP);
            interfacePanel.Controls.Add(USB_Port_label);
            interfacePanel.Controls.Add(ButtonConnect);
            interfacePanel.Controls.Add(StopFilter);
            interfacePanel.Controls.Add(ButtonDisconnect);
            interfacePanel.Controls.Add(ButtonAdvanceDate);
            interfacePanel.Location = new Point(5, 5);
            interfacePanel.Name = "interfacePanel";
            interfacePanel.Size = new Size(212, 447);
            interfacePanel.TabIndex = 134;
            // 
            // GameVersionImg
            // 
            GameVersionImg.BackgroundImageLayout = ImageLayout.Zoom;
            GameVersionImg.Location = new Point(6, 97);
            GameVersionImg.Name = "GameVersionImg";
            GameVersionImg.Size = new Size(200, 80);
            GameVersionImg.TabIndex = 138;
            GameVersionImg.TabStop = false;
            // 
            // Protocol_dropdown
            // 
            Protocol_dropdown.FormattingEnabled = true;
            Protocol_dropdown.Items.AddRange(new object[] { "Wi-Fi", "USB" });
            Protocol_dropdown.Location = new Point(138, 33);
            Protocol_dropdown.MaxDropDownItems = 2;
            Protocol_dropdown.Name = "Protocol_dropdown";
            Protocol_dropdown.Size = new Size(68, 23);
            Protocol_dropdown.TabIndex = 137;
            Protocol_dropdown.Text = "w";
            Protocol_dropdown.SelectedIndexChanged += Protocol_dropdown_SelectedIndexChanged;
            // 
            // Protocol_label
            // 
            Protocol_label.AutoSize = true;
            Protocol_label.Location = new Point(6, 36);
            Protocol_label.Name = "Protocol_label";
            Protocol_label.Size = new Size(120, 15);
            Protocol_label.TabIndex = 136;
            Protocol_label.Text = "Connection Protocol:";
            // 
            // extrasPanel
            // 
            extrasPanel.border = Color.Gainsboro;
            extrasPanel.Controls.Add(Streak);
            extrasPanel.Controls.Add(TotalMiss);
            extrasPanel.Controls.Add(LabelShinyCount);
            extrasPanel.Controls.Add(DaySkipSuccessRate);
            extrasPanel.Controls.Add(SearchTime);
            extrasPanel.Controls.Add(LabelLoadedRaids);
            extrasPanel.Location = new Point(223, 380);
            extrasPanel.Name = "extrasPanel";
            extrasPanel.Size = new Size(350, 72);
            extrasPanel.TabIndex = 135;
            // 
            // Streak
            // 
            Streak.AutoSize = true;
            Streak.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Streak.Location = new Point(263, 54);
            Streak.Name = "Streak";
            Streak.Size = new Size(51, 15);
            Streak.TabIndex = 17;
            Streak.Text = "Streak: 0";
            // 
            // TotalMiss
            // 
            TotalMiss.AutoSize = true;
            TotalMiss.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TotalMiss.Location = new Point(3, 54);
            TotalMiss.Name = "TotalMiss";
            TotalMiss.Size = new Size(74, 15);
            TotalMiss.TabIndex = 16;
            TotalMiss.Text = "Total Miss:  0";
            // 
            // LabelShinyCount
            // 
            LabelShinyCount.AutoSize = true;
            LabelShinyCount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LabelShinyCount.Location = new Point(218, 20);
            LabelShinyCount.Name = "LabelShinyCount";
            LabelShinyCount.Size = new Size(96, 15);
            LabelShinyCount.TabIndex = 15;
            LabelShinyCount.Text = "Shinies Missed: 0";
            LabelShinyCount.MouseDown += LabelShinyCount_Click;
            // 
            // DaySkipSuccessRate
            // 
            DaySkipSuccessRate.AutoSize = true;
            DaySkipSuccessRate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DaySkipSuccessRate.Location = new Point(3, 37);
            DaySkipSuccessRate.Name = "DaySkipSuccessRate";
            DaySkipSuccessRate.Size = new Size(67, 15);
            DaySkipSuccessRate.TabIndex = 14;
            DaySkipSuccessRate.Text = "Skip Rate: 0";
            // 
            // SearchTime
            // 
            SearchTime.AutoSize = true;
            SearchTime.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTime.Location = new Point(3, 3);
            SearchTime.Name = "SearchTime";
            SearchTime.Size = new Size(88, 15);
            SearchTime.TabIndex = 13;
            SearchTime.Text = "Search Time: 0s";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 479);
            Controls.Add(extrasPanel);
            Controls.Add(interfacePanel);
            Controls.Add(navigationPanel);
            Controls.Add(spacerPanel1);
            Controls.Add(spacerPanel2);
            Controls.Add(statsPanel);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)Sprite).EndInit();
            ((System.ComponentModel.ISupportInitialize)GemIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchTimer).EndInit();
            groupBox1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shinyBox).EndInit();
            navigationPanel.ResumeLayout(false);
            interfacePanel.ResumeLayout(false);
            interfacePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GameVersionImg).EndInit();
            extrasPanel.ResumeLayout(false);
            extrasPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip;
        private Button ButtonDisconnect;
        private Button ButtonConnect;
        private TextBox InputSwitchIP;
        private Label LabelSwitchIP;
        private Label LabelLoadedRaids;
        private Button ButtonNext;
        private Button ButtonPrevious;
        private Button ButtonReadRaids;
        private Button ButtonAdvanceDate;
        private Button ButtonViewRAM;
        private Button ButtonResetTime;
        private Button StopFilter;
        private PictureBox Sprite;
        private PictureBox GemIcon;
        private Button ButtonDownloadEvents;
        private Button ConfigSettings;
        private Button Rewards;
        private Label LabelSandwichBonus;
        private ComboBox RaidBoost;
        private CheckBox CheckEnableFilters;
        private ComboBox ComboIndex;
        private Button SendScreenshot;
        private System.Timers.Timer SearchTimer;
        private Button btnOpenMap;
        private GroupBox groupBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripStatusLabel ToolStripStatusLabel;
        private Label USB_Port_label;
        private TextBox USB_Port_TB;
        private Button StopAdvance_Button;
        private ToolStripStatusLabel Label_DayAdvance;
        private CustomUI.MyPanel interfacePanel;
        private CustomUI.MyPanel navigationPanel;
        private CustomUI.MyPanel spacerPanel1;
        private CustomUI.MyPanel spacerPanel2;
        private CustomUI.MyPanel statsPanel;
        private CustomUI.MyPanel extrasPanel;
        private CustomUI.TransparentTextBox Scale;
        private CustomUI.TransparentTextBox Nature;
        private CustomUI.TransparentTextBox TeraType;
        private CustomUI.TransparentTextBox Ability;
        private CustomUI.TransparentTextBox IVs;
        private CustomUI.TransparentTextBox Gender;
        private CustomUI.TransparentTextBox Species;
        private CustomUI.TransparentTextBox Difficulty;
        private CustomUI.TransparentTextBox Seed;
        private CustomUI.TransparentTextBox Area;
        private CustomUI.RoundLabel labelEvent;
        private CustomUI.RoundLabel LabelScale;
        private CustomUI.RoundLabel LabelNature;
        private CustomUI.RoundLabel LabelTeraType;
        private CustomUI.RoundLabel LabelArea;
        private CustomUI.RoundLabel LabelMoves;
        private CustomUI.RoundLabel LabelAbility;
        private CustomUI.RoundLabel LabelIVs;
        private CustomUI.RoundLabel LabelGender;
        private CustomUI.RoundLabel LabelSpecies;
        private CustomUI.RoundLabel LabelDifficulty;
        private CustomUI.RoundLabel LabelPID;
        private CustomUI.RoundLabel LabelEC;
        private PictureBox shinyBox;
        private CustomUI.RoundLabel LabelSeed;
        private ComboBox Protocol_dropdown;
        private Label Protocol_label;
        private Button ButtonScreenState;
        private Button CopyAnnounce;
        private TransparentTextBox PID;
        private TransparentTextBox EC;
        private TransparentTextBox Move1;
        private TransparentTextBox Move2;
        private TransparentTextBox Move4;
        private TransparentTextBox Move3;
        private Label LabelShinyCount;
        private Label DaySkipSuccessRate;
        private Label SearchTime;
        private PictureBox GameVersionImg;
        //private Label label2;
        //private Label label1;
        private Label Streak;
        private Label TotalMiss;
        private ToolTip FomoTip;
    }
}
