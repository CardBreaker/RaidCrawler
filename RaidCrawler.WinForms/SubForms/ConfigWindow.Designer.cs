using SysBot.Base;

namespace RaidCrawler.WinForms.SubForms
{
    partial class ConfigWindow
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
            this.components = new System.ComponentModel.Container();
            this.L_AdvanceDate = new System.Windows.Forms.Label();
            this.L_BaseDelay = new System.Windows.Forms.Label();
            this.SystemDDownPresses = new System.Windows.Forms.NumericUpDown();
            this.L_DdownInput = new System.Windows.Forms.Label();
            this.NavigateToSettings = new System.Windows.Forms.NumericUpDown();
            this.OpenSettings = new System.Windows.Forms.NumericUpDown();
            this.OpenHome = new System.Windows.Forms.NumericUpDown();
            this.L_OpenHOME = new System.Windows.Forms.Label();
            this.L_NavigateSettings = new System.Windows.Forms.Label();
            this.L_OpenSettingsDelay = new System.Windows.Forms.Label();
            this.L_ScrollSystem = new System.Windows.Forms.Label();
            this.Hold = new System.Windows.Forms.NumericUpDown();
            this.L_SubmenuDelay = new System.Windows.Forms.Label();
            this.Submenu = new System.Windows.Forms.NumericUpDown();
            this.L_DateChangeDelay = new System.Windows.Forms.Label();
            this.DateChange = new System.Windows.Forms.NumericUpDown();
            this.L_ReturnHomeDelay = new System.Windows.Forms.Label();
            this.ReturnHome = new System.Windows.Forms.NumericUpDown();
            this.L_ReOpenGameDelay = new System.Windows.Forms.Label();
            this.ReturnGame = new System.Windows.Forms.NumericUpDown();
            this.L_DaysToSkip = new System.Windows.Forms.Label();
            this.DaysToSkip = new System.Windows.Forms.NumericUpDown();
            this.UseTouch = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.TitleSearchTime = new System.Windows.Forms.CheckBox();
            this.CopyEmoji = new System.Windows.Forms.CheckBox();
            this.MapBackground = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ExperimentalView = new System.Windows.Forms.CheckBox();
            this.InstanceName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.LocationGroup = new System.Windows.Forms.GroupBox();
            this.BlueberryScanCheck = new System.Windows.Forms.CheckBox();
            this.KitakamiScanCheck = new System.Windows.Forms.CheckBox();
            this.PaldeaScanCheck = new System.Windows.Forms.CheckBox();
            this.Protocol_dropdown = new System.Windows.Forms.ComboBox();
            this.Protocol_label = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.LabelEventProgress = new System.Windows.Forms.Label();
            this.EventProgress = new System.Windows.Forms.ComboBox();
            this.LabelGame = new System.Windows.Forms.Label();
            this.Game = new System.Windows.Forms.ComboBox();
            this.LabelStoryProgress = new System.Windows.Forms.Label();
            this.StoryProgress = new System.Windows.Forms.ComboBox();
            this.tabMatch = new System.Windows.Forms.TabPage();
            this.SaveGame = new System.Windows.Forms.CheckBox();
            this.LabelMatchFound = new System.Windows.Forms.Label();
            this.FocusWindow = new System.Windows.Forms.CheckBox();
            this.EnableAlert = new System.Windows.Forms.CheckBox();
            this.PlayTone = new System.Windows.Forms.CheckBox();
            this.AlertMessage = new System.Windows.Forms.TextBox();
            this.tabAdvanceDate = new System.Windows.Forms.TabPage();
            this.UseMapTrick = new CheckBox();
            this.ZyroMethod = new CheckBox();
            this.ExtraOverworldWait = new System.Windows.Forms.NumericUpDown();
            this.L_ExtraOverworldWait = new System.Windows.Forms.Label();
            this.L_SystemReset = new System.Windows.Forms.Label();
            this.RelaunchDelay = new System.Windows.Forms.NumericUpDown();
            this.L_RelaunchDelay = new System.Windows.Forms.Label();
            this.SystemReset = new System.Windows.Forms.NumericUpDown();
            this.UseSetStick = new System.Windows.Forms.CheckBox();
            this.DodgeSystemUpdate = new System.Windows.Forms.CheckBox();
            this.SaveGameDelay = new System.Windows.Forms.NumericUpDown();
            this.L_SaveGame = new System.Windows.Forms.Label();
            this.L_OvershootHold = new System.Windows.Forms.Label();
            this.SystemOvershoot = new System.Windows.Forms.NumericUpDown();
            this.UseOvershoot = new System.Windows.Forms.CheckBox();
            this.BaseDelay = new System.Windows.Forms.NumericUpDown();
            this.tabWebhook = new System.Windows.Forms.TabPage();
            this.EnableFomoNotifications = new System.Windows.Forms.CheckBox();
            this.FomoWebhook = new System.Windows.Forms.TextBox();
            this.EnableDiscordNotifications = new System.Windows.Forms.CheckBox();
            this.DiscordWebhook = new System.Windows.Forms.TextBox();
            this.IVspacerLabel = new System.Windows.Forms.Label();
            this.IVspacer = new System.Windows.Forms.TextBox();
            this.EmojiConfig = new System.Windows.Forms.Button();
            this.labelWebhooks = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.DiscordMessageContent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnTestWebHook = new System.Windows.Forms.Button();
            this.denToggle = new System.Windows.Forms.CheckBox();
            this.LocationSettings_label = new System.Windows.Forms.Label();
            this.IVstyle = new System.Windows.Forms.ComboBox();
            this.IVverbose = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.EnableEmoji = new System.Windows.Forms.CheckBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelAppName = new System.Windows.Forms.Label();
            this.picAppIcon = new System.Windows.Forms.PictureBox();
            this.labelAppVersion = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SystemDDownPresses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigateToSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Submenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysToSkip)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.LocationGroup.SuspendLayout();
            this.tabMatch.SuspendLayout();
            this.tabAdvanceDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraOverworldWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelaunchDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemReset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveGameDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemOvershoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDelay)).BeginInit();
            this.tabWebhook.SuspendLayout();
            this.tabAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // L_AdvanceDate
            // 
            this.L_AdvanceDate.AutoSize = true;
            this.L_AdvanceDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L_AdvanceDate.Location = new System.Drawing.Point(6, 3);
            this.L_AdvanceDate.Name = "L_AdvanceDate";
            this.L_AdvanceDate.Size = new System.Drawing.Size(233, 15);
            this.L_AdvanceDate.TabIndex = 6;
            this.L_AdvanceDate.Text = "Advance Date Options (all timings in ms):";
            // 
            // L_BaseDelay
            // 
            this.L_BaseDelay.AutoSize = true;
            this.L_BaseDelay.Location = new System.Drawing.Point(6, 149);
            this.L_BaseDelay.Name = "L_BaseDelay";
            this.L_BaseDelay.Size = new System.Drawing.Size(196, 15);
            this.L_BaseDelay.TabIndex = 8;
            this.L_BaseDelay.Text = "Base delay to be added to all inputs:";
            // 
            // SystemDDownPresses
            // 
            this.SystemDDownPresses.Location = new System.Drawing.Point(265, 292);
            this.SystemDDownPresses.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.SystemDDownPresses.Name = "SystemDDownPresses";
            this.SystemDDownPresses.Size = new System.Drawing.Size(68, 23);
            this.SystemDDownPresses.TabIndex = 10;
            this.SystemDDownPresses.Value = new decimal(new int[] {
            38,
            0,
            0,
            0});
            // 
            // L_DdownInput
            // 
            this.L_DdownInput.AutoSize = true;
            this.L_DdownInput.Location = new System.Drawing.Point(6, 294);
            this.L_DdownInput.Name = "L_DdownInput";
            this.L_DdownInput.Size = new System.Drawing.Size(228, 15);
            this.L_DdownInput.TabIndex = 11;
            this.L_DdownInput.Text = "DDOWN inputs to get to \"Date and Time\":";
            // 
            // NavigateToSettings
            // 
            this.NavigateToSettings.Location = new System.Drawing.Point(265, 205);
            this.NavigateToSettings.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NavigateToSettings.Name = "NavigateToSettings";
            this.NavigateToSettings.Size = new System.Drawing.Size(68, 23);
            this.NavigateToSettings.TabIndex = 16;
            this.NavigateToSettings.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // OpenSettings
            // 
            this.OpenSettings.Location = new System.Drawing.Point(265, 234);
            this.OpenSettings.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(68, 23);
            this.OpenSettings.TabIndex = 17;
            this.OpenSettings.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // OpenHome
            // 
            this.OpenHome.Location = new System.Drawing.Point(265, 176);
            this.OpenHome.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.OpenHome.Name = "OpenHome";
            this.OpenHome.Size = new System.Drawing.Size(68, 23);
            this.OpenHome.TabIndex = 18;
            this.OpenHome.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            // 
            // L_OpenHOME
            // 
            this.L_OpenHOME.AutoSize = true;
            this.L_OpenHOME.Location = new System.Drawing.Point(6, 178);
            this.L_OpenHOME.Name = "L_OpenHOME";
            this.L_OpenHOME.Size = new System.Drawing.Size(140, 15);
            this.L_OpenHOME.TabIndex = 19;
            this.L_OpenHOME.Text = "Open Home Menu delay:";
            // 
            // L_NavigateSettings
            // 
            this.L_NavigateSettings.AutoSize = true;
            this.L_NavigateSettings.Location = new System.Drawing.Point(6, 207);
            this.L_NavigateSettings.Name = "L_NavigateSettings";
            this.L_NavigateSettings.Size = new System.Drawing.Size(146, 15);
            this.L_NavigateSettings.TabIndex = 20;
            this.L_NavigateSettings.Text = "Navigate to settings delay:";
            // 
            // L_OpenSettingsDelay
            // 
            this.L_OpenSettingsDelay.AutoSize = true;
            this.L_OpenSettingsDelay.Location = new System.Drawing.Point(6, 236);
            this.L_OpenSettingsDelay.Name = "L_OpenSettingsDelay";
            this.L_OpenSettingsDelay.Size = new System.Drawing.Size(114, 15);
            this.L_OpenSettingsDelay.TabIndex = 21;
            this.L_OpenSettingsDelay.Text = "Open settings delay:";
            // 
            // L_ScrollSystem
            // 
            this.L_ScrollSystem.AutoSize = true;
            this.L_ScrollSystem.Location = new System.Drawing.Point(6, 265);
            this.L_ScrollSystem.Name = "L_ScrollSystem";
            this.L_ScrollSystem.Size = new System.Drawing.Size(187, 15);
            this.L_ScrollSystem.TabIndex = 23;
            this.L_ScrollSystem.Text = "Time to hold to scroll to \"System\":";
            // 
            // Hold
            // 
            this.Hold.Location = new System.Drawing.Point(265, 263);
            this.Hold.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Hold.Name = "Hold";
            this.Hold.Size = new System.Drawing.Size(68, 23);
            this.Hold.TabIndex = 22;
            this.Hold.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // L_SubmenuDelay
            // 
            this.L_SubmenuDelay.AutoSize = true;
            this.L_SubmenuDelay.Location = new System.Drawing.Point(6, 323);
            this.L_SubmenuDelay.Name = "L_SubmenuDelay";
            this.L_SubmenuDelay.Size = new System.Drawing.Size(123, 15);
            this.L_SubmenuDelay.TabIndex = 25;
            this.L_SubmenuDelay.Text = "Open submenu delay:";
            // 
            // Submenu
            // 
            this.Submenu.Location = new System.Drawing.Point(265, 321);
            this.Submenu.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Submenu.Name = "Submenu";
            this.Submenu.Size = new System.Drawing.Size(68, 23);
            this.Submenu.TabIndex = 24;
            this.Submenu.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // L_DateChangeDelay
            // 
            this.L_DateChangeDelay.AutoSize = true;
            this.L_DateChangeDelay.Location = new System.Drawing.Point(6, 352);
            this.L_DateChangeDelay.Name = "L_DateChangeDelay";
            this.L_DateChangeDelay.Size = new System.Drawing.Size(138, 15);
            this.L_DateChangeDelay.TabIndex = 27;
            this.L_DateChangeDelay.Text = "Open date change delay:";
            // 
            // DateChange
            // 
            this.DateChange.Location = new System.Drawing.Point(265, 350);
            this.DateChange.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.DateChange.Name = "DateChange";
            this.DateChange.Size = new System.Drawing.Size(68, 23);
            this.DateChange.TabIndex = 26;
            this.DateChange.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // L_ReturnHomeDelay
            // 
            this.L_ReturnHomeDelay.AutoSize = true;
            this.L_ReturnHomeDelay.Location = new System.Drawing.Point(6, 410);
            this.L_ReturnHomeDelay.Name = "L_ReturnHomeDelay";
            this.L_ReturnHomeDelay.Size = new System.Drawing.Size(160, 15);
            this.L_ReturnHomeDelay.TabIndex = 29;
            this.L_ReturnHomeDelay.Text = "Return to Home Menu delay:";
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(265, 408);
            this.ReturnHome.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(68, 23);
            this.ReturnHome.TabIndex = 28;
            this.ReturnHome.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // L_ReOpenGameDelay
            // 
            this.L_ReOpenGameDelay.AutoSize = true;
            this.L_ReOpenGameDelay.Location = new System.Drawing.Point(6, 439);
            this.L_ReOpenGameDelay.Name = "L_ReOpenGameDelay";
            this.L_ReOpenGameDelay.Size = new System.Drawing.Size(119, 15);
            this.L_ReOpenGameDelay.TabIndex = 31;
            this.L_ReOpenGameDelay.Text = "Re-open game delay:";
            // 
            // ReturnGame
            // 
            this.ReturnGame.Location = new System.Drawing.Point(265, 437);
            this.ReturnGame.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ReturnGame.Name = "ReturnGame";
            this.ReturnGame.Size = new System.Drawing.Size(68, 23);
            this.ReturnGame.TabIndex = 30;
            this.ReturnGame.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // L_DaysToSkip
            // 
            this.L_DaysToSkip.AutoSize = true;
            this.L_DaysToSkip.Location = new System.Drawing.Point(6, 381);
            this.L_DaysToSkip.Name = "L_DaysToSkip";
            this.L_DaysToSkip.Size = new System.Drawing.Size(179, 15);
            this.L_DaysToSkip.TabIndex = 33;
            this.L_DaysToSkip.Text = "Number of days/months to skip:";
            // 
            // DaysToSkip
            // 
            this.DaysToSkip.Location = new System.Drawing.Point(265, 379);
            this.DaysToSkip.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.DaysToSkip.Name = "DaysToSkip";
            this.DaysToSkip.Size = new System.Drawing.Size(68, 23);
            this.DaysToSkip.TabIndex = 32;
            // 
            // UseTouch
            // 
            this.UseTouch.AutoSize = true;
            this.UseTouch.Location = new System.Drawing.Point(8, 62);
            this.UseTouch.Name = "UseTouch";
            this.UseTouch.Size = new System.Drawing.Size(267, 19);
            this.UseTouch.TabIndex = 36;
            this.UseTouch.Text = "Use touch screen inputs (faster, experimental)";
            this.UseTouch.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGeneral);
            this.tabControl1.Controls.Add(this.tabMatch);
            this.tabControl1.Controls.Add(this.tabAdvanceDate);
            this.tabControl1.Controls.Add(this.tabWebhook);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(349, 646);
            this.tabControl1.TabIndex = 41;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.TitleSearchTime);
            this.tabGeneral.Controls.Add(this.CopyEmoji);
            this.tabGeneral.Controls.Add(this.MapBackground);
            this.tabGeneral.Controls.Add(this.label13);
            this.tabGeneral.Controls.Add(this.ExperimentalView);
            this.tabGeneral.Controls.Add(this.InstanceName);
            this.tabGeneral.Controls.Add(this.label17);
            this.tabGeneral.Controls.Add(this.LocationGroup);
            this.tabGeneral.Controls.Add(this.Protocol_dropdown);
            this.tabGeneral.Controls.Add(this.Protocol_label);
            this.tabGeneral.Controls.Add(this.label23);
            this.tabGeneral.Controls.Add(this.LabelEventProgress);
            this.tabGeneral.Controls.Add(this.EventProgress);
            this.tabGeneral.Controls.Add(this.LabelGame);
            this.tabGeneral.Controls.Add(this.Game);
            this.tabGeneral.Controls.Add(this.LabelStoryProgress);
            this.tabGeneral.Controls.Add(this.StoryProgress);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(341, 623);
            this.tabGeneral.TabIndex = 5;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // TitleSearchTime
            // 
            this.TitleSearchTime.AutoSize = true;
            this.TitleSearchTime.Location = new System.Drawing.Point(8, 383);
            this.TitleSearchTime.Name = "TitleSearchTime";
            this.TitleSearchTime.Size = new System.Drawing.Size(170, 19);
            this.TitleSearchTime.TabIndex = 118;
            this.TitleSearchTime.Text = "Include Search Time in Title";
            this.TitleSearchTime.UseVisualStyleBackColor = true;
            // 
            // CopyEmoji
            // 
            this.CopyEmoji.AutoSize = true;
            this.CopyEmoji.Location = new System.Drawing.Point(8, 358);
            this.CopyEmoji.Name = "CopyEmoji";
            this.CopyEmoji.Size = new System.Drawing.Size(174, 19);
            this.CopyEmoji.TabIndex = 117;
            this.CopyEmoji.Text = "Enable Copy Message Emoji";
            this.CopyEmoji.UseVisualStyleBackColor = true;
            // 
            // MapBackground
            // 
            this.MapBackground.AutoSize = true;
            this.MapBackground.Location = new System.Drawing.Point(8, 333);
            this.MapBackground.Name = "MapBackground";
            this.MapBackground.Size = new System.Drawing.Size(169, 19);
            this.MapBackground.TabIndex = 116;
            this.MapBackground.Text = "Enable Map as Background";
            this.MapBackground.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(8, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 15);
            this.label13.TabIndex = 114;
            this.label13.Text = "Miscellaneous ";
            // 
            // ExperimentalView
            // 
            this.ExperimentalView.AutoSize = true;
            this.ExperimentalView.Location = new System.Drawing.Point(8, 308);
            this.ExperimentalView.Name = "ExperimentalView";
            this.ExperimentalView.Size = new System.Drawing.Size(284, 19);
            this.ExperimentalView.TabIndex = 115;
            this.ExperimentalView.Text = "Toggle Streamer Tera Raid View (Requires Restart)";
            this.ExperimentalView.UseVisualStyleBackColor = true;
            // 
            // InstanceName
            // 
            this.InstanceName.Location = new System.Drawing.Point(6, 21);
            this.InstanceName.Name = "InstanceName";
            this.InstanceName.Size = new System.Drawing.Size(327, 23);
            this.InstanceName.TabIndex = 113;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(8, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 15);
            this.label17.TabIndex = 112;
            this.label17.Text = "Instance Name:";
            // 
            // LocationGroup
            //
            this.LocationGroup.Controls.Add(this.BlueberryScanCheck);
            this.LocationGroup.Controls.Add(this.KitakamiScanCheck);
            this.LocationGroup.Controls.Add(this.PaldeaScanCheck);
            this.LocationGroup.Location = new System.Drawing.Point(8, 190);
            this.LocationGroup.Name = "LocationGroup";
            this.LocationGroup.Size = new System.Drawing.Size(200, 98);
            this.LocationGroup.TabIndex = 115;
            this.LocationGroup.TabStop = false;
            this.LocationGroup.Text = "Scan Locations";
            // 
            // KitakamiScanCheck
            // 
            this.KitakamiScanCheck.AutoSize = true;
            this.KitakamiScanCheck.Checked = true;
            this.KitakamiScanCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KitakamiScanCheck.Location = new System.Drawing.Point(6, 47);
            this.KitakamiScanCheck.Name = "KitakamiScanCheck";
            this.KitakamiScanCheck.Size = new System.Drawing.Size(72, 19);
            this.KitakamiScanCheck.TabIndex = 113;
            this.KitakamiScanCheck.Text = "Kitakami";
            this.KitakamiScanCheck.UseVisualStyleBackColor = true;
            // 
            // PaldeaScanCheck
            // 
            this.PaldeaScanCheck.AutoSize = true;
            this.PaldeaScanCheck.Checked = true;
            this.PaldeaScanCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PaldeaScanCheck.Location = new System.Drawing.Point(6, 22);
            this.PaldeaScanCheck.Name = "PaldeaScanCheck";
            this.PaldeaScanCheck.Size = new System.Drawing.Size(61, 19);
            this.PaldeaScanCheck.TabIndex = 112;
            this.PaldeaScanCheck.Text = "Paldea";
            this.PaldeaScanCheck.UseVisualStyleBackColor = true;
            // 
            // Protocol_dropdown
            // 
            this.Protocol_dropdown.FormattingEnabled = true;
            this.Protocol_dropdown.Items.AddRange(new object[] {
                "Wi-Fi",
                "USB"});
            this.Protocol_dropdown.Location = new System.Drawing.Point(137, 161);
            this.Protocol_dropdown.MaxDropDownItems = 2;
            this.Protocol_dropdown.Name = "Protocol_dropdown";
            this.Protocol_dropdown.Size = new System.Drawing.Size(68, 23);
            this.Protocol_dropdown.TabIndex = 111;
            this.Protocol_dropdown.Text = "w";
            Protocol_dropdown.SelectedValueChanged += Protocol_Changed;
            // 
            // Protocol_label
            // 
            this.Protocol_label.AutoSize = true;
            this.Protocol_label.Location = new System.Drawing.Point(5, 164);
            this.Protocol_label.Name = "Protocol_label";
            this.Protocol_label.Size = new System.Drawing.Size(120, 15);
            this.Protocol_label.TabIndex = 110;
            this.Protocol_label.Text = "Connection Protocol:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(8, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 15);
            this.label23.TabIndex = 109;
            this.label23.Text = "Game Settings";
            // 
            // LabelEventProgress
            // 
            this.LabelEventProgress.AutoSize = true;
            this.LabelEventProgress.Location = new System.Drawing.Point(5, 136);
            this.LabelEventProgress.Name = "LabelEventProgress";
            this.LabelEventProgress.Size = new System.Drawing.Size(117, 15);
            this.LabelEventProgress.TabIndex = 108;
            this.LabelEventProgress.Text = "Event Progress Level:";
            // 
            // EventProgress
            // 
            this.EventProgress.Enabled = false;
            this.EventProgress.FormattingEnabled = true;
            this.EventProgress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.EventProgress.Location = new System.Drawing.Point(157, 133);
            this.EventProgress.Name = "EventProgress";
            this.EventProgress.Size = new System.Drawing.Size(48, 23);
            this.EventProgress.TabIndex = 107;
            this.EventProgress.Text = "w";
            // 
            // LabelGame
            // 
            this.LabelGame.AutoSize = true;
            this.LabelGame.Location = new System.Drawing.Point(6, 81);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(41, 15);
            this.LabelGame.TabIndex = 106;
            this.LabelGame.Text = "Game:";
            // 
            // Game
            // 
            this.Game.FormattingEnabled = true;
            this.Game.Items.AddRange(new object[] {
            "Scarlet",
            "Violet"});
            this.Game.Location = new System.Drawing.Point(109, 78);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(96, 23);
            this.Game.TabIndex = 105;
            this.Game.Text = "w";
            Game.SelectedIndexChanged += Game_SelectedIndexChanged;
            // 
            // LabelStoryProgress
            // 
            this.LabelStoryProgress.AutoSize = true;
            this.LabelStoryProgress.Location = new System.Drawing.Point(6, 108);
            this.LabelStoryProgress.Name = "LabelStoryProgress";
            this.LabelStoryProgress.Size = new System.Drawing.Size(115, 15);
            this.LabelStoryProgress.TabIndex = 104;
            this.LabelStoryProgress.Text = "Story Progress Level:";
            // 
            // StoryProgress
            // 
            this.StoryProgress.Enabled = false;
            this.StoryProgress.FormattingEnabled = true;
            this.StoryProgress.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.StoryProgress.Location = new System.Drawing.Point(157, 105);
            this.StoryProgress.Name = "StoryProgress";
            this.StoryProgress.Size = new System.Drawing.Size(48, 23);
            this.StoryProgress.TabIndex = 103;
            this.StoryProgress.Text = "w";
            // 
            // tabMatch
            // 
            this.tabMatch.Controls.Add(this.SaveGame);
            this.tabMatch.Controls.Add(this.LabelMatchFound);
            this.tabMatch.Controls.Add(this.FocusWindow);
            this.tabMatch.Controls.Add(this.EnableAlert);
            this.tabMatch.Controls.Add(this.PlayTone);
            this.tabMatch.Controls.Add(this.AlertMessage);
            this.tabMatch.Location = new System.Drawing.Point(4, 24);
            this.tabMatch.Name = "tabMatch";
            this.tabMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabMatch.Size = new System.Drawing.Size(341, 623);
            this.tabMatch.TabIndex = 0;
            this.tabMatch.Text = "Match";
            this.tabMatch.UseVisualStyleBackColor = true;
            // 
            // SaveGame
            // 
            this.SaveGame.AutoSize = true;
            this.SaveGame.Location = new System.Drawing.Point(8, 113);
            this.SaveGame.Name = "SaveGame";
            this.SaveGame.Size = new System.Drawing.Size(172, 19);
            this.SaveGame.TabIndex = 42;
            this.SaveGame.Text = "Save game on match found";
            this.SaveGame.UseVisualStyleBackColor = true;
            // 
            // LabelMatchFound
            // 
            this.LabelMatchFound.AutoSize = true;
            this.LabelMatchFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelMatchFound.Location = new System.Drawing.Point(6, 3);
            this.LabelMatchFound.Name = "LabelMatchFound";
            this.LabelMatchFound.Size = new System.Drawing.Size(137, 15);
            this.LabelMatchFound.TabIndex = 3;
            this.LabelMatchFound.Text = "When a match is found:";
            // 
            // FocusWindow
            // 
            this.FocusWindow.AutoSize = true;
            this.FocusWindow.Location = new System.Drawing.Point(8, 44);
            this.FocusWindow.Name = "FocusWindow";
            this.FocusWindow.Size = new System.Drawing.Size(123, 19);
            this.FocusWindow.TabIndex = 1;
            this.FocusWindow.Text = "Focus RaidCrawler";
            this.FocusWindow.UseVisualStyleBackColor = true;
            // 
            // EnableAlert
            // 
            this.EnableAlert.AutoSize = true;
            this.EnableAlert.Location = new System.Drawing.Point(8, 65);
            this.EnableAlert.Name = "EnableAlert";
            this.EnableAlert.Size = new System.Drawing.Size(293, 19);
            this.EnableAlert.TabIndex = 2;
            this.EnableAlert.Text = "Show an alert window with the following message:";
            this.EnableAlert.UseVisualStyleBackColor = true;
            EnableAlert.CheckedChanged += EnableAlert_CheckedChanged;
            // 
            // PlayTone
            // 
            this.PlayTone.AutoSize = true;
            this.PlayTone.Location = new System.Drawing.Point(8, 23);
            this.PlayTone.Name = "PlayTone";
            this.PlayTone.Size = new System.Drawing.Size(84, 19);
            this.PlayTone.TabIndex = 0;
            this.PlayTone.Text = "Play a tone";
            this.PlayTone.UseVisualStyleBackColor = true;
            // 
            // AlertMessage
            // 
            this.AlertMessage.Location = new System.Drawing.Point(8, 84);
            this.AlertMessage.Name = "AlertMessage";
            this.AlertMessage.Size = new System.Drawing.Size(327, 23);
            this.AlertMessage.TabIndex = 4;
            // 
            // tabAdvanceDate
            //
            this.tabAdvanceDate.Controls.Add(this.ZyroMethod);
            this.tabAdvanceDate.Controls.Add(this.UseMapTrick);
            this.tabAdvanceDate.Controls.Add(this.ExtraOverworldWait);
            this.tabAdvanceDate.Controls.Add(this.L_ExtraOverworldWait);
            this.tabAdvanceDate.Controls.Add(this.L_SystemReset);
            this.tabAdvanceDate.Controls.Add(this.RelaunchDelay);
            this.tabAdvanceDate.Controls.Add(this.L_RelaunchDelay);
            this.tabAdvanceDate.Controls.Add(this.SystemReset);
            this.tabAdvanceDate.Controls.Add(this.UseSetStick);
            this.tabAdvanceDate.Controls.Add(this.DodgeSystemUpdate);
            this.tabAdvanceDate.Controls.Add(this.SaveGameDelay);
            this.tabAdvanceDate.Controls.Add(this.L_SaveGame);
            this.tabAdvanceDate.Controls.Add(this.L_OvershootHold);
            this.tabAdvanceDate.Controls.Add(this.SystemOvershoot);
            this.tabAdvanceDate.Controls.Add(this.UseOvershoot);
            this.tabAdvanceDate.Controls.Add(this.L_AdvanceDate);
            this.tabAdvanceDate.Controls.Add(this.L_BaseDelay);
            this.tabAdvanceDate.Controls.Add(this.UseTouch);
            this.tabAdvanceDate.Controls.Add(this.SystemDDownPresses);
            this.tabAdvanceDate.Controls.Add(this.L_DdownInput);
            this.tabAdvanceDate.Controls.Add(this.L_DaysToSkip);
            this.tabAdvanceDate.Controls.Add(this.NavigateToSettings);
            this.tabAdvanceDate.Controls.Add(this.DaysToSkip);
            this.tabAdvanceDate.Controls.Add(this.OpenSettings);
            this.tabAdvanceDate.Controls.Add(this.L_ReOpenGameDelay);
            this.tabAdvanceDate.Controls.Add(this.OpenHome);
            this.tabAdvanceDate.Controls.Add(this.ReturnGame);
            this.tabAdvanceDate.Controls.Add(this.L_OpenHOME);
            this.tabAdvanceDate.Controls.Add(this.L_ReturnHomeDelay);
            this.tabAdvanceDate.Controls.Add(this.L_NavigateSettings);
            this.tabAdvanceDate.Controls.Add(this.ReturnHome);
            this.tabAdvanceDate.Controls.Add(this.L_OpenSettingsDelay);
            this.tabAdvanceDate.Controls.Add(this.L_DateChangeDelay);
            this.tabAdvanceDate.Controls.Add(this.Hold);
            this.tabAdvanceDate.Controls.Add(this.DateChange);
            this.tabAdvanceDate.Controls.Add(this.L_ScrollSystem);
            this.tabAdvanceDate.Controls.Add(this.L_SubmenuDelay);
            this.tabAdvanceDate.Controls.Add(this.Submenu);
            this.tabAdvanceDate.Controls.Add(this.BaseDelay);
            this.tabAdvanceDate.Location = new System.Drawing.Point(4, 24);
            this.tabAdvanceDate.Name = "tabAdvanceDate";
            this.tabAdvanceDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdvanceDate.Size = new System.Drawing.Size(341, 623);
            this.tabAdvanceDate.TabIndex = 1;
            this.tabAdvanceDate.Text = "Advance Date";
            this.tabAdvanceDate.UseVisualStyleBackColor = true;
            //
            // ZyroMethod
            //
            ZyroMethod.AutoSize = true;
            ZyroMethod.Location = new Point(8, 22);
            ZyroMethod.Name = "ZyroMethod";
            ZyroMethod.Size = new Size(319, 19);
            ZyroMethod.TabIndex = 53;
            ZyroMethod.Text = "Use Zyro's usb-botbase fork methods (approx. 4-5x faster)";
            ZyroMethod.UseVisualStyleBackColor = true;
            //
            // UseMapTrick
            //
            UseMapTrick.AutoSize = true;
            UseMapTrick.Location = new Point(8, 42);
            UseMapTrick.Name = "UseMapTrick";
            UseMapTrick.Size = new Size(164, 19);
            UseMapTrick.TabIndex = 52;
            UseMapTrick.Text = "Use Map Trick to avoid lag";
            UseMapTrick.UseVisualStyleBackColor = true;
            // 
            // ExtraOverworldWait
            // 
            this.ExtraOverworldWait.Location = new System.Drawing.Point(265, 585);
            this.ExtraOverworldWait.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ExtraOverworldWait.Name = "ExtraOverworldWait";
            this.ExtraOverworldWait.Size = new System.Drawing.Size(68, 23);
            this.ExtraOverworldWait.TabIndex = 51;
            // 
            // L_ExtraOverworldWait
            // 
            this.L_ExtraOverworldWait.AutoSize = true;
            this.L_ExtraOverworldWait.Location = new System.Drawing.Point(7, 587);
            this.L_ExtraOverworldWait.Name = "L_ExtraOverworldWait";
            this.L_ExtraOverworldWait.Size = new System.Drawing.Size(218, 15);
            this.L_ExtraOverworldWait.TabIndex = 50;
            this.L_ExtraOverworldWait.Text = "Extra time to wait for Overworld to load:";
            this.L_ExtraOverworldWait.UseMnemonic = false;
            // 
            // L_SystemReset
            // 
            this.L_SystemReset.AutoSize = true;
            this.L_SystemReset.Location = new System.Drawing.Point(7, 527);
            this.L_SystemReset.Name = "L_SystemReset";
            this.L_SystemReset.Size = new System.Drawing.Size(203, 15);
            this.L_SystemReset.TabIndex = 46;
            this.L_SystemReset.Text = "Relaunch game after this many skips:";
            // 
            // RelaunchDelay
            // 
            this.RelaunchDelay.Location = new System.Drawing.Point(265, 555);
            this.RelaunchDelay.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.RelaunchDelay.Name = "RelaunchDelay";
            this.RelaunchDelay.Size = new System.Drawing.Size(68, 23);
            this.RelaunchDelay.TabIndex = 49;
            // 
            // L_RelaunchDelay
            // 
            this.L_RelaunchDelay.AutoSize = true;
            this.L_RelaunchDelay.Location = new System.Drawing.Point(7, 557);
            this.L_RelaunchDelay.Name = "L_RelaunchDelay";
            this.L_RelaunchDelay.Size = new System.Drawing.Size(198, 15);
            this.L_RelaunchDelay.TabIndex = 48;
            this.L_RelaunchDelay.Text = "Extra time to wait to relaunch game:";
            // 
            // SystemReset
            // 
            this.SystemReset.Location = new System.Drawing.Point(265, 525);
            this.SystemReset.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SystemReset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SystemReset.Name = "SystemReset";
            this.SystemReset.Size = new System.Drawing.Size(68, 23);
            this.SystemReset.TabIndex = 47;
            this.SystemReset.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // UseSetStick
            // 
            this.UseSetStick.AutoSize = true;
            this.UseSetStick.Location = new System.Drawing.Point(8, 122);
            this.UseSetStick.Name = "UseSetStick";
            this.UseSetStick.Size = new System.Drawing.Size(222, 19);
            this.UseSetStick.TabIndex = 45;
            this.UseSetStick.Text = "Use SetStick instead of PressAndHold";
            this.UseSetStick.UseVisualStyleBackColor = true;
            UseSetStick.CheckedChanged += UseSetStick_CheckedChanged;
            // 
            // DodgeSystemUpdate
            // 
            this.DodgeSystemUpdate.AutoSize = true;
            this.DodgeSystemUpdate.Location = new System.Drawing.Point(8, 102);
            this.DodgeSystemUpdate.Name = "DodgeSystemUpdate";
            this.DodgeSystemUpdate.Size = new System.Drawing.Size(184, 19);
            this.DodgeSystemUpdate.TabIndex = 44;
            this.DodgeSystemUpdate.Text = "Dodge system update prompt";
            this.DodgeSystemUpdate.UseVisualStyleBackColor = true;
            // 
            // SaveGameDelay
            // 
            this.SaveGameDelay.Location = new System.Drawing.Point(265, 495);
            this.SaveGameDelay.Name = "SaveGameDelay";
            this.SaveGameDelay.Size = new System.Drawing.Size(68, 23);
            this.SaveGameDelay.TabIndex = 43;
            // 
            // L_SaveGame
            // 
            this.L_SaveGame.AutoSize = true;
            this.L_SaveGame.Location = new System.Drawing.Point(6, 498);
            this.L_SaveGame.Name = "L_SaveGame";
            this.L_SaveGame.Size = new System.Drawing.Size(186, 15);
            this.L_SaveGame.TabIndex = 42;
            this.L_SaveGame.Text = "Time to wait for the game to save:";
            // 
            // L_OvershootHold
            // 
            this.L_OvershootHold.AutoSize = true;
            this.L_OvershootHold.Location = new System.Drawing.Point(6, 468);
            this.L_OvershootHold.Name = "L_OvershootHold";
            this.L_OvershootHold.Size = new System.Drawing.Size(236, 15);
            this.L_OvershootHold.TabIndex = 40;
            this.L_OvershootHold.Text = "Time to hold to overshoot \"Date and Time\":";
            // 
            // SystemOvershoot
            // 
            this.SystemOvershoot.Location = new System.Drawing.Point(265, 466);
            this.SystemOvershoot.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.SystemOvershoot.Name = "SystemOvershoot";
            this.SystemOvershoot.Size = new System.Drawing.Size(68, 23);
            this.SystemOvershoot.TabIndex = 39;
            this.SystemOvershoot.Value = new decimal(new int[] {
            950,
            0,
            0,
            0});
            // 
            // UseOvershoot
            // 
            this.UseOvershoot.AutoSize = true;
            this.UseOvershoot.Location = new System.Drawing.Point(8, 82);
            this.UseOvershoot.Name = "UseOvershoot";
            this.UseOvershoot.Size = new System.Drawing.Size(319, 19);
            this.UseOvershoot.TabIndex = 38;
            this.UseOvershoot.Text = "Use overshoot instead of DDOWN (faster, experimental)";
            this.UseOvershoot.UseVisualStyleBackColor = true;
            UseOvershoot.CheckedChanged += UseOvershoot_CheckedChanged;
            // 
            // BaseDelay
            // 
            this.BaseDelay.Location = new System.Drawing.Point(265, 147);
            this.BaseDelay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.BaseDelay.Name = "BaseDelay";
            this.BaseDelay.Size = new System.Drawing.Size(68, 23);
            this.BaseDelay.TabIndex = 9;
            // 
            // tabWebhook
            // 
            this.tabWebhook.Controls.Add(this.EnableFomoNotifications);
            this.tabWebhook.Controls.Add(this.FomoWebhook);
            this.tabWebhook.Controls.Add(this.EnableDiscordNotifications);
            this.tabWebhook.Controls.Add(this.DiscordWebhook);
            this.tabWebhook.Controls.Add(this.IVspacerLabel);
            this.tabWebhook.Controls.Add(this.IVspacer);
            this.tabWebhook.Controls.Add(this.EmojiConfig);
            this.tabWebhook.Controls.Add(this.labelWebhooks);
            this.tabWebhook.Controls.Add(this.label21);
            this.tabWebhook.Controls.Add(this.DiscordMessageContent);
            this.tabWebhook.Controls.Add(this.label14);
            this.tabWebhook.Controls.Add(this.btnTestWebHook);
            this.tabWebhook.Controls.Add(this.denToggle);
            this.tabWebhook.Controls.Add(this.LocationSettings_label);
            this.tabWebhook.Controls.Add(this.IVstyle);
            this.tabWebhook.Controls.Add(this.IVverbose);
            this.tabWebhook.Controls.Add(this.label19);
            this.tabWebhook.Controls.Add(this.label18);
            this.tabWebhook.Controls.Add(this.EnableEmoji);
            this.tabWebhook.Location = new System.Drawing.Point(4, 24);
            this.tabWebhook.Name = "tabWebhook";
            this.tabWebhook.Size = new System.Drawing.Size(341, 623);
            this.tabWebhook.TabIndex = 3;
            this.tabWebhook.Text = "Webhook";
            this.tabWebhook.UseVisualStyleBackColor = true;
            // 
            // EnableFomoNotifications
            // 
            this.EnableFomoNotifications.AutoSize = true;
            this.EnableFomoNotifications.Location = new System.Drawing.Point(8, 434);
            this.EnableFomoNotifications.Name = "EnableFomoNotifications";
            this.EnableFomoNotifications.Size = new System.Drawing.Size(312, 19);
            this.EnableFomoNotifications.TabIndex = 52;
            this.EnableFomoNotifications.Text = "FOMO alerts to Discord webhooks (comma separated)";
            this.toolTip1.SetToolTip(this.EnableFomoNotifications, "It has no functional purpose, it just makes me feel bad!");
            this.EnableFomoNotifications.UseVisualStyleBackColor = true;
            EnableFomoNotifications.CheckedChanged += EnableFomoNotifications_CheckedChanged;
            // 
            // FomoWebhook
            // 
            this.FomoWebhook.Location = new System.Drawing.Point(6, 454);
            this.FomoWebhook.Name = "FomoWebhook";
            this.FomoWebhook.Size = new System.Drawing.Size(327, 23);
            this.FomoWebhook.TabIndex = 51;
            // 
            // EnableDiscordNotifications
            // 
            this.EnableDiscordNotifications.AutoSize = true;
            this.EnableDiscordNotifications.Location = new System.Drawing.Point(8, 19);
            this.EnableDiscordNotifications.Name = "EnableDiscordNotifications";
            this.EnableDiscordNotifications.Size = new System.Drawing.Size(303, 19);
            this.EnableDiscordNotifications.TabIndex = 50;
            this.EnableDiscordNotifications.Text = "Send alerts to Discord webhooks (comma separated)";
            this.EnableDiscordNotifications.UseVisualStyleBackColor = true;
            EnableDiscordNotifications.CheckedChanged += EnableDiscordNotifications_CheckedChanged;
            // 
            // DiscordWebhook
            // 
            this.DiscordWebhook.Location = new System.Drawing.Point(6, 39);
            this.DiscordWebhook.Name = "DiscordWebhook";
            this.DiscordWebhook.Size = new System.Drawing.Size(327, 23);
            this.DiscordWebhook.TabIndex = 49;
            // 
            // IVspacerLabel
            // 
            this.IVspacerLabel.AutoSize = true;
            this.IVspacerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IVspacerLabel.Location = new System.Drawing.Point(6, 263);
            this.IVspacerLabel.Name = "IVspacerLabel";
            this.IVspacerLabel.Size = new System.Drawing.Size(55, 15);
            this.IVspacerLabel.TabIndex = 48;
            this.IVspacerLabel.Text = "IV Spacer";
            // 
            // IVspacer
            // 
            this.IVspacer.Location = new System.Drawing.Point(6, 281);
            this.IVspacer.Name = "IVspacer";
            this.IVspacer.Size = new System.Drawing.Size(100, 23);
            this.IVspacer.TabIndex = 47;
            // 
            // EmojiConfig
            // 
            this.EmojiConfig.Location = new System.Drawing.Point(6, 137);
            this.EmojiConfig.Name = "EmojiConfig";
            this.EmojiConfig.Size = new System.Drawing.Size(100, 23);
            this.EmojiConfig.TabIndex = 46;
            this.EmojiConfig.Text = "Emoji Config";
            this.EmojiConfig.UseVisualStyleBackColor = true;
            EmojiConfig.Click += EmojiConfig_Click;
            // 
            // labelWebhooks
            // 
            this.labelWebhooks.AutoSize = true;
            this.labelWebhooks.Location = new System.Drawing.Point(6, 383);
            this.labelWebhooks.Name = "labelWebhooks";
            this.labelWebhooks.Size = new System.Drawing.Size(85, 15);
            this.labelWebhooks.TabIndex = 44;
            this.labelWebhooks.Text = "Webhooks are ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(8, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 15);
            this.label21.TabIndex = 43;
            this.label21.Text = "Webhook Settings";
            // 
            // DiscordMessageContent
            // 
            this.DiscordMessageContent.Location = new System.Drawing.Point(6, 87);
            this.DiscordMessageContent.Name = "DiscordMessageContent";
            this.DiscordMessageContent.Size = new System.Drawing.Size(327, 23);
            this.DiscordMessageContent.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(285, 15);
            this.label14.TabIndex = 41;
            this.label14.Text = "Message Content (ping with <@numerical_user_id>)";
            // 
            // btnTestWebHook
            // 
            this.btnTestWebHook.Location = new System.Drawing.Point(234, 379);
            this.btnTestWebHook.Name = "btnTestWebHook";
            this.btnTestWebHook.Size = new System.Drawing.Size(104, 23);
            this.btnTestWebHook.TabIndex = 22;
            this.btnTestWebHook.Text = "Test Webhook";
            this.btnTestWebHook.UseVisualStyleBackColor = true;
            btnTestWebHook.Click += BtnTestWebHook_Click;
            // 
            // denToggle
            // 
            this.denToggle.AutoSize = true;
            this.denToggle.Checked = true;
            this.denToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.denToggle.Location = new System.Drawing.Point(8, 336);
            this.denToggle.Name = "denToggle";
            this.denToggle.Size = new System.Drawing.Size(79, 19);
            this.denToggle.TabIndex = 21;
            this.denToggle.Text = "Show Den";
            this.denToggle.UseVisualStyleBackColor = true;
            // 
            // LocationSettings_label
            // 
            this.LocationSettings_label.AutoSize = true;
            this.LocationSettings_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LocationSettings_label.Location = new System.Drawing.Point(6, 318);
            this.LocationSettings_label.Name = "LocationSettings_label";
            this.LocationSettings_label.Size = new System.Drawing.Size(103, 15);
            this.LocationSettings_label.TabIndex = 20;
            this.LocationSettings_label.Text = "Location Settings";
            // 
            // IVstyle
            // 
            this.IVstyle.FormattingEnabled = true;
            this.IVstyle.Items.AddRange(new object[] {
            "Emoji",
            "Highlighted Numerical",
            "Numerical"});
            this.IVstyle.Location = new System.Drawing.Point(6, 233);
            this.IVstyle.Name = "IVstyle";
            this.IVstyle.Size = new System.Drawing.Size(121, 23);
            this.IVstyle.TabIndex = 8;
            // 
            // IVverbose
            // 
            this.IVverbose.AutoSize = true;
            this.IVverbose.Location = new System.Drawing.Point(8, 194);
            this.IVverbose.Name = "IVverbose";
            this.IVverbose.Size = new System.Drawing.Size(167, 19);
            this.IVverbose.TabIndex = 5;
            this.IVverbose.Text = "Output IV names (Verbose)";
            this.IVverbose.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(6, 215);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 15);
            this.label19.TabIndex = 2;
            this.label19.Text = "IV style";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(8, 176);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 15);
            this.label18.TabIndex = 1;
            this.label18.Text = "IV Settings";
            // 
            // EnableEmoji
            // 
            this.EnableEmoji.AutoSize = true;
            this.EnableEmoji.Checked = true;
            this.EnableEmoji.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnableEmoji.Location = new System.Drawing.Point(8, 116);
            this.EnableEmoji.Name = "EnableEmoji";
            this.EnableEmoji.Size = new System.Drawing.Size(94, 19);
            this.EnableEmoji.TabIndex = 0;
            this.EnableEmoji.Text = "Enable Emoji";
            this.EnableEmoji.UseVisualStyleBackColor = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.label2);
            this.tabAbout.Controls.Add(this.label1);
            this.tabAbout.Controls.Add(this.linkLabel2);
            this.tabAbout.Controls.Add(this.linkLabel1);
            this.tabAbout.Controls.Add(this.labelAppName);
            this.tabAbout.Controls.Add(this.picAppIcon);
            this.tabAbout.Controls.Add(this.labelAppVersion);
            this.tabAbout.Location = new System.Drawing.Point(4, 24);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(341, 623);
            this.tabAbout.TabIndex = 4;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Support this modified version of RaidCrawler here!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-3, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Support the original RaidCrawler and its skilled creators here!";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(43, 308);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(265, 15);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/CardBreaker/RaidCrawler";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 43);
            this.linkLabel1.Location = new System.Drawing.Point(55, 249);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(253, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/LegoFigure11/RaidCrawler";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(67)))), ((int)(((byte)(149)))));
            this.labelAppName.Location = new System.Drawing.Point(98, 134);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(152, 32);
            this.labelAppName.TabIndex = 2;
            this.labelAppName.Text = "RaidCrawler";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picAppIcon
            // 
            this.picAppIcon.BackgroundImage = global::RaidCrawler.WinForms.Properties.Resources.mightiestmark;
            this.picAppIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAppIcon.Location = new System.Drawing.Point(0, 10);
            this.picAppIcon.Name = "picAppIcon";
            this.picAppIcon.Size = new System.Drawing.Size(341, 151);
            this.picAppIcon.TabIndex = 1;
            this.picAppIcon.TabStop = false;
            // 
            // labelAppVersion
            // 
            this.labelAppVersion.AutoSize = true;
            this.labelAppVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppVersion.Location = new System.Drawing.Point(129, 167);
            this.labelAppVersion.Name = "labelAppVersion";
            this.labelAppVersion.Size = new System.Drawing.Size(88, 15);
            this.labelAppVersion.TabIndex = 0;
            this.labelAppVersion.Text = "v0.0.0-000000";
            this.labelAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save.Location = new System.Drawing.Point(2, 647);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(345, 32);
            this.Save.TabIndex = 116;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // BlueberryScanCheck
            // 
            BlueberryScanCheck.AutoSize = true;
            BlueberryScanCheck.Checked = true;
            BlueberryScanCheck.CheckState = CheckState.Checked;
            BlueberryScanCheck.Location = new Point(6, 72);
            BlueberryScanCheck.Name = "BlueberryScanCheck";
            BlueberryScanCheck.Size = new Size(76, 19);
            BlueberryScanCheck.TabIndex = 114;
            BlueberryScanCheck.Text = "Blueberry";
            BlueberryScanCheck.UseVisualStyleBackColor = true;
            // 
            // ConfigWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 682);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RaidCrawler Settings";
            FormClosing += Config_Closing;
            ((System.ComponentModel.ISupportInitialize)(this.SystemDDownPresses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavigateToSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OpenHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Submenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaysToSkip)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.LocationGroup.ResumeLayout(false);
            this.LocationGroup.PerformLayout();
            this.tabMatch.ResumeLayout(false);
            this.tabMatch.PerformLayout();
            this.tabAdvanceDate.ResumeLayout(false);
            this.tabAdvanceDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExtraOverworldWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelaunchDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemReset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaveGameDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemOvershoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseDelay)).EndInit();
            this.tabWebhook.ResumeLayout(false);
            this.tabWebhook.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAppIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label L_AdvanceDate;
        private Label L_BaseDelay;
        private NumericUpDown SystemDDownPresses;
        private Label L_DdownInput;
        private NumericUpDown NavigateToSettings;
        private NumericUpDown OpenSettings;
        private NumericUpDown OpenHome;
        private Label L_OpenHOME;
        private Label L_NavigateSettings;
        private Label L_OpenSettingsDelay;
        private Label L_ScrollSystem;
        private NumericUpDown Hold;
        private Label L_SubmenuDelay;
        private NumericUpDown Submenu;
        private Label L_DateChangeDelay;
        private NumericUpDown DateChange;
        private Label L_ReturnHomeDelay;
        private NumericUpDown ReturnHome;
        private Label L_ReOpenGameDelay;
        private NumericUpDown ReturnGame;
        private Label L_DaysToSkip;
        private NumericUpDown DaysToSkip;
        private CheckBox UseTouch;
        private TabControl tabControl1;
        private TabPage tabAdvanceDate;
        private Label L_OvershootHold;
        private NumericUpDown SystemOvershoot;
        private CheckBox UseOvershoot;
        private TabPage tabWebhook;
        private CheckBox EnableEmoji;
        private Label label19;
        private Label label18;
        private ComboBox IVstyle;
        private CheckBox IVverbose;
        private CheckBox denToggle;
        private Label LocationSettings_label;
        private Button btnTestWebHook;
        private TextBox DiscordMessageContent;
        private Label label14;
        private Label labelWebhooks;
        private TabPage tabAbout;
        private Label labelAppVersion;
        private LinkLabel linkLabel1;
        private PictureBox picAppIcon;
        private TabPage tabGeneral;
        private Label label23;
        private Label LabelEventProgress;
        private ComboBox EventProgress;
        private Label LabelGame;
        private ComboBox Game;
        private Label LabelStoryProgress;
        private ComboBox StoryProgress;
        private Button EmojiConfig;
        private ComboBox Protocol_dropdown;
        private Label Protocol_label;
        private NumericUpDown BaseDelay;
        private NumericUpDown SaveGameDelay;
        private Label L_SaveGame;
        private CheckBox DodgeSystemUpdate;
        private CheckBox UseSetStick;
        private TextBox IVspacer;
        private Label IVspacerLabel;
        private LinkLabel linkLabel2;
        private Label labelAppName;
        private TextBox InstanceName;
        private Label label17;
        private CheckBox EnableDiscordNotifications;
        private TextBox DiscordWebhook;
        private Label label13;
        private CheckBox ExperimentalView;
        private TabPage tabMatch;
        private CheckBox SaveGame;
        private Label LabelMatchFound;
        private CheckBox FocusWindow;
        private CheckBox EnableAlert;
        private CheckBox PlayTone;
        private TextBox AlertMessage;
        private Button Save;
        private CheckBox CopyEmoji;
        private CheckBox MapBackground;
        private CheckBox TitleSearchTime;
        private Label label21;
        private Label label2;
        private Label label1;
        private CheckBox EnableFomoNotifications;
        private TextBox FomoWebhook;
        private ToolTip toolTip1;
        private CheckBox PaldeaScanCheck;
        private GroupBox LocationGroup;
        private CheckBox KitakamiScanCheck;
        private NumericUpDown SystemReset;
        private Label L_SystemReset;
        private NumericUpDown RelaunchDelay;
        private Label L_RelaunchDelay;
        private NumericUpDown ExtraOverworldWait;
        private Label L_ExtraOverworldWait;
        private CheckBox UseMapTrick;
        private CheckBox ZyroMethod;
        private CheckBox BlueberryScanCheck;
    }
}
