namespace ObidoBingo.UI
{
    partial class GameSettingsForm
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
            _gameSettingsControl = new GameSettingsControl();
            _cancelButton = new Button();
            _okButton = new Button();
            _requiredSquares = new CheckBox();
            SuspendLayout();
            // 
            // _gameSettingsControl
            // 
            _gameSettingsControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _gameSettingsControl.Location = new Point(3, 3);
            _gameSettingsControl.Name = "_gameSettingsControl";
            _gameSettingsControl.Size = new Size(239, 203);
            _gameSettingsControl.TabIndex = 0;
            // 
            // _cancelButton
            // 
            _cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _cancelButton.Location = new Point(167, 212);
            _cancelButton.Name = "_cancelButton";
            _cancelButton.Size = new Size(75, 23);
            _cancelButton.TabIndex = 2;
            _cancelButton.Text = "Cancel";
            _cancelButton.UseVisualStyleBackColor = true;
            _cancelButton.Click += _cancelButton_Click;
            // 
            // _okButton
            // 
            _okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _okButton.Location = new Point(86, 212);
            _okButton.Name = "_okButton";
            _okButton.Size = new Size(75, 23);
            _okButton.TabIndex = 1;
            _okButton.Text = "OK";
            _okButton.UseVisualStyleBackColor = true;
            _okButton.Click += _okButton_Click;
            // 
            // _requiredSquares
            // 
            _requiredSquares.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _requiredSquares.Location = new Point(12, 159);
            _requiredSquares.Name = "_requiredSquares";
            _requiredSquares.Size = new Size(164, 19);
            _requiredSquares.TabIndex = 7;
            _requiredSquares.Text = "Check for required squars:";
            _requiredSquares.UseVisualStyleBackColor = true;
            // 
            // GameSettingsForm
            // 
            AcceptButton = _okButton;
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            CancelButton = _cancelButton;
            ClientSize = new Size(247, 242);
            Controls.Add(_okButton);
            Controls.Add(_cancelButton);
            Controls.Add(_gameSettingsControl);
            Controls.Add(_requiredSquares);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "GameSettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Lobby Settings";
            ResumeLayout(false);
        }

        #endregion

        private GameSettingsControl _gameSettingsControl;
        private Button _cancelButton;
        private Button _okButton;
        private CheckBox _requiredSquares;
    }
}