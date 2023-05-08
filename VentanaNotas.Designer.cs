namespace InciGest
{
    partial class VentanaNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaNotas));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textoMensaje = new Bunifu.UI.WinForms.BunifuTextBox();
            this.botonEnviar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tablaMensajes = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaMensajes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tablaMensajes);
            this.panel1.Controls.Add(this.botonEnviar);
            this.panel1.Controls.Add(this.textoMensaje);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 465);
            this.panel1.TabIndex = 0;
            // 
            // textoMensaje
            // 
            this.textoMensaje.AcceptsReturn = false;
            this.textoMensaje.AcceptsTab = false;
            this.textoMensaje.AnimationSpeed = 200;
            this.textoMensaje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textoMensaje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textoMensaje.BackColor = System.Drawing.Color.White;
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
            this.textoMensaje.Location = new System.Drawing.Point(10, 420);
            this.textoMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.textoMensaje.MaxLength = 32767;
            this.textoMensaje.MinimumSize = new System.Drawing.Size(1, 1);
            this.textoMensaje.Modified = false;
            this.textoMensaje.Multiline = false;
            this.textoMensaje.Name = "textoMensaje";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoMensaje.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textoMensaje.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoMensaje.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textoMensaje.OnIdleState = stateProperties8;
            this.textoMensaje.Padding = new System.Windows.Forms.Padding(4);
            this.textoMensaje.PasswordChar = '\0';
            this.textoMensaje.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textoMensaje.PlaceholderText = "Enter text";
            this.textoMensaje.ReadOnly = false;
            this.textoMensaje.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textoMensaje.SelectedText = "";
            this.textoMensaje.SelectionLength = 0;
            this.textoMensaje.SelectionStart = 0;
            this.textoMensaje.ShortcutsEnabled = true;
            this.textoMensaje.Size = new System.Drawing.Size(627, 41);
            this.textoMensaje.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textoMensaje.TabIndex = 3;
            this.textoMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textoMensaje.TextMarginBottom = 0;
            this.textoMensaje.TextMarginLeft = 3;
            this.textoMensaje.TextMarginTop = 0;
            this.textoMensaje.TextPlaceholder = "Enter text";
            this.textoMensaje.UseSystemPasswordChar = false;
            this.textoMensaje.WordWrap = true;
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.botonEnviar.CustomizableEdges = borderEdges2;
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
            this.botonEnviar.IdleBorderRadius = 39;
            this.botonEnviar.IdleBorderThickness = 1;
            this.botonEnviar.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.botonEnviar.IdleIconLeftImage = null;
            this.botonEnviar.IdleIconRightImage = null;
            this.botonEnviar.IndicateFocus = false;
            this.botonEnviar.Location = new System.Drawing.Point(645, 420);
            this.botonEnviar.Margin = new System.Windows.Forms.Padding(4);
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
            this.botonEnviar.Size = new System.Drawing.Size(139, 41);
            this.botonEnviar.TabIndex = 6;
            this.botonEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.botonEnviar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.botonEnviar.TextMarginLeft = 0;
            this.botonEnviar.TextPadding = new System.Windows.Forms.Padding(0);
            this.botonEnviar.UseDefaultRadiusAndThickness = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // tablaMensajes
            // 
            this.tablaMensajes.AllowUserToAddRows = false;
            this.tablaMensajes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tablaMensajes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaMensajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaMensajes.ColumnHeadersHeight = 17;
            this.tablaMensajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaMensajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaMensajes.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaMensajes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaMensajes.Location = new System.Drawing.Point(3, 3);
            this.tablaMensajes.MultiSelect = false;
            this.tablaMensajes.Name = "tablaMensajes";
            this.tablaMensajes.ReadOnly = true;
            this.tablaMensajes.RowHeadersVisible = false;
            this.tablaMensajes.RowHeadersWidth = 51;
            this.tablaMensajes.Size = new System.Drawing.Size(787, 410);
            this.tablaMensajes.TabIndex = 7;
            this.tablaMensajes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaMensajes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaMensajes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaMensajes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaMensajes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaMensajes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaMensajes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaMensajes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaMensajes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaMensajes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tablaMensajes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaMensajes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaMensajes.ThemeStyle.HeaderStyle.Height = 17;
            this.tablaMensajes.ThemeStyle.ReadOnly = true;
            this.tablaMensajes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaMensajes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaMensajes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tablaMensajes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaMensajes.ThemeStyle.RowsStyle.Height = 22;
            this.tablaMensajes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaMensajes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // VentanaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaNotas";
            this.Text = "VentanaNotas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaMensajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox textoMensaje;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton botonEnviar;
        private Guna.UI2.WinForms.Guna2DataGridView tablaMensajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}