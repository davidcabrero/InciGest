namespace InciGest
{
    partial class VentanaMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaMensaje));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.textoMensaje = new Bunifu.UI.WinForms.BunifuTextBox();
            this.textoAsunto = new Bunifu.UI.WinForms.BunifuTextBox();
            this.botonEnviar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.mensajeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textoMensaje
            // 
            this.textoMensaje.AcceptsReturn = false;
            this.textoMensaje.AcceptsTab = false;
            this.textoMensaje.AnimationSpeed = 200;
            this.textoMensaje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textoMensaje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textoMensaje.BackColor = System.Drawing.Color.Transparent;
            this.textoMensaje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textoMensaje.BackgroundImage")));
            this.textoMensaje.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textoMensaje.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textoMensaje.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textoMensaje.BorderColorIdle = System.Drawing.Color.Silver;
            this.textoMensaje.BorderRadius = 30;
            this.textoMensaje.BorderThickness = 1;
            this.textoMensaje.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textoMensaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoMensaje.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textoMensaje.DefaultText = "";
            this.textoMensaje.FillColor = System.Drawing.Color.White;
            this.textoMensaje.HideSelection = true;
            this.textoMensaje.IconLeft = null;
            this.textoMensaje.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textoMensaje.IconPadding = 10;
            this.textoMensaje.IconRight = null;
            this.textoMensaje.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textoMensaje.Lines = new string[0];
            this.textoMensaje.Location = new System.Drawing.Point(16, 164);
            this.textoMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoMensaje.MaxLength = 32767;
            this.textoMensaje.MinimumSize = new System.Drawing.Size(1, 1);
            this.textoMensaje.Modified = false;
            this.textoMensaje.Multiline = false;
            this.textoMensaje.Name = "textoMensaje";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoMensaje.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textoMensaje.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoMensaje.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoMensaje.OnIdleState = stateProperties4;
            this.textoMensaje.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoMensaje.PasswordChar = '\0';
            this.textoMensaje.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textoMensaje.PlaceholderText = "Enter text";
            this.textoMensaje.ReadOnly = false;
            this.textoMensaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textoMensaje.SelectedText = "";
            this.textoMensaje.SelectionLength = 0;
            this.textoMensaje.SelectionStart = 0;
            this.textoMensaje.ShortcutsEnabled = true;
            this.textoMensaje.Size = new System.Drawing.Size(1035, 348);
            this.textoMensaje.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textoMensaje.TabIndex = 1;
            this.textoMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textoMensaje.TextMarginBottom = 0;
            this.textoMensaje.TextMarginLeft = 3;
            this.textoMensaje.TextMarginTop = 0;
            this.textoMensaje.TextPlaceholder = "Enter text";
            this.textoMensaje.UseSystemPasswordChar = false;
            this.textoMensaje.WordWrap = true;
            // 
            // textoAsunto
            // 
            this.textoAsunto.AcceptsReturn = false;
            this.textoAsunto.AcceptsTab = false;
            this.textoAsunto.AnimationSpeed = 200;
            this.textoAsunto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textoAsunto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textoAsunto.BackColor = System.Drawing.Color.Transparent;
            this.textoAsunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textoAsunto.BackgroundImage")));
            this.textoAsunto.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textoAsunto.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textoAsunto.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textoAsunto.BorderColorIdle = System.Drawing.Color.Silver;
            this.textoAsunto.BorderRadius = 30;
            this.textoAsunto.BorderThickness = 1;
            this.textoAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textoAsunto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textoAsunto.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textoAsunto.DefaultText = "";
            this.textoAsunto.FillColor = System.Drawing.Color.White;
            this.textoAsunto.HideSelection = true;
            this.textoAsunto.IconLeft = null;
            this.textoAsunto.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textoAsunto.IconPadding = 10;
            this.textoAsunto.IconRight = null;
            this.textoAsunto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textoAsunto.Lines = new string[0];
            this.textoAsunto.Location = new System.Drawing.Point(115, 106);
            this.textoAsunto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoAsunto.MaxLength = 32767;
            this.textoAsunto.MinimumSize = new System.Drawing.Size(1, 1);
            this.textoAsunto.Modified = false;
            this.textoAsunto.Multiline = false;
            this.textoAsunto.Name = "textoAsunto";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoAsunto.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textoAsunto.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoAsunto.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoAsunto.OnIdleState = stateProperties8;
            this.textoAsunto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoAsunto.PasswordChar = '\0';
            this.textoAsunto.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textoAsunto.PlaceholderText = "Enter text";
            this.textoAsunto.ReadOnly = false;
            this.textoAsunto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textoAsunto.SelectedText = "";
            this.textoAsunto.SelectionLength = 0;
            this.textoAsunto.SelectionStart = 0;
            this.textoAsunto.ShortcutsEnabled = true;
            this.textoAsunto.Size = new System.Drawing.Size(936, 50);
            this.textoAsunto.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textoAsunto.TabIndex = 2;
            this.textoAsunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textoAsunto.TextMarginBottom = 0;
            this.textoAsunto.TextMarginLeft = 3;
            this.textoAsunto.TextMarginTop = 0;
            this.textoAsunto.TextPlaceholder = "Enter text";
            this.textoAsunto.UseSystemPasswordChar = false;
            this.textoAsunto.WordWrap = true;
            // 
            // botonEnviar
            // 
            this.botonEnviar.AllowAnimations = true;
            this.botonEnviar.AllowMouseEffects = true;
            this.botonEnviar.AllowToggling = false;
            this.botonEnviar.AnimationSpeed = 200;
            this.botonEnviar.AutoGenerateColors = false;
            this.botonEnviar.AutoRoundBorders = true;
            this.botonEnviar.AutoSizeLeftIcon = true;
            this.botonEnviar.AutoSizeRightIcon = true;
            this.botonEnviar.BackColor = System.Drawing.Color.Transparent;
            this.botonEnviar.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.botonEnviar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonEnviar.BackgroundImage")));
            this.botonEnviar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.botonEnviar.ButtonText = "Enviar";
            this.botonEnviar.ButtonTextMarginLeft = 0;
            this.botonEnviar.ColorContrastOnClick = 45;
            this.botonEnviar.ColorContrastOnHover = 45;
            this.botonEnviar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.botonEnviar.CustomizableEdges = borderEdges1;
            this.botonEnviar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.botonEnviar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.botonEnviar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.botonEnviar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.botonEnviar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.botonEnviar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botonEnviar.ForeColor = System.Drawing.Color.White;
            this.botonEnviar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botonEnviar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.botonEnviar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.botonEnviar.IconMarginLeft = 11;
            this.botonEnviar.IconPadding = 10;
            this.botonEnviar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botonEnviar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.botonEnviar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.botonEnviar.IconSize = 25;
            this.botonEnviar.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.botonEnviar.IdleBorderRadius = 46;
            this.botonEnviar.IdleBorderThickness = 1;
            this.botonEnviar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.botonEnviar.IdleIconLeftImage = null;
            this.botonEnviar.IdleIconRightImage = null;
            this.botonEnviar.IndicateFocus = false;
            this.botonEnviar.Location = new System.Drawing.Point(432, 530);
            this.botonEnviar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.botonEnviar.OnDisabledState.BorderRadius = 1;
            this.botonEnviar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.botonEnviar.OnDisabledState.BorderThickness = 1;
            this.botonEnviar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.botonEnviar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.botonEnviar.OnDisabledState.IconLeftImage = null;
            this.botonEnviar.OnDisabledState.IconRightImage = null;
            this.botonEnviar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.botonEnviar.onHoverState.BorderRadius = 1;
            this.botonEnviar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.botonEnviar.onHoverState.BorderThickness = 1;
            this.botonEnviar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.botonEnviar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.botonEnviar.onHoverState.IconLeftImage = null;
            this.botonEnviar.onHoverState.IconRightImage = null;
            this.botonEnviar.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.botonEnviar.OnIdleState.BorderRadius = 1;
            this.botonEnviar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.botonEnviar.OnIdleState.BorderThickness = 1;
            this.botonEnviar.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.botonEnviar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.botonEnviar.OnIdleState.IconLeftImage = null;
            this.botonEnviar.OnIdleState.IconRightImage = null;
            this.botonEnviar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.botonEnviar.OnPressedState.BorderRadius = 1;
            this.botonEnviar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.botonEnviar.OnPressedState.BorderThickness = 1;
            this.botonEnviar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.botonEnviar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.botonEnviar.OnPressedState.IconLeftImage = null;
            this.botonEnviar.OnPressedState.IconRightImage = null;
            this.botonEnviar.Size = new System.Drawing.Size(200, 48);
            this.botonEnviar.TabIndex = 5;
            this.botonEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonEnviar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonEnviar.TextMarginLeft = 0;
            this.botonEnviar.TextPadding = new System.Windows.Forms.Padding(0);
            this.botonEnviar.UseDefaultRadiusAndThickness = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Asunto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mensajeLabel
            // 
            this.mensajeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeLabel.Location = new System.Drawing.Point(16, 33);
            this.mensajeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mensajeLabel.Name = "mensajeLabel";
            this.mensajeLabel.Size = new System.Drawing.Size(1035, 50);
            this.mensajeLabel.TabIndex = 7;
            this.mensajeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 593);
            this.Controls.Add(this.mensajeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.textoAsunto);
            this.Controls.Add(this.textoMensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "VentanaMensaje";
            this.Text = "Enviar Mensaje";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox textoMensaje;
        private Bunifu.UI.WinForms.BunifuTextBox textoAsunto;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton botonEnviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mensajeLabel;
    }
}