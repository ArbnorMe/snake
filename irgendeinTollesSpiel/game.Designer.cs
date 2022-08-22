namespace irgendeinTollesSpiel
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ballX = new System.Windows.Forms.Label();
            this.ball_position_text1 = new System.Windows.Forms.Label();
            this.ballY = new System.Windows.Forms.Label();
            this.ball_position_text2 = new System.Windows.Forms.Label();
            this.eingabe_ausgabe = new System.Windows.Forms.Label();
            this.eingabe_text = new System.Windows.Forms.Label();
            this.foodTimer = new System.Windows.Forms.Timer(this.components);
            this.punkteAnzeige = new System.Windows.Forms.Label();
            this.punkteText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1053, 632);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "https://arbnor.me/";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ballX
            // 
            this.ballX.AutoSize = true;
            this.ballX.Font = new System.Drawing.Font("Bauhaus 93", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballX.ForeColor = System.Drawing.Color.White;
            this.ballX.Location = new System.Drawing.Point(202, 9);
            this.ballX.Name = "ballX";
            this.ballX.Size = new System.Drawing.Size(31, 32);
            this.ballX.TabIndex = 19;
            this.ballX.Text = "0";
            // 
            // ball_position_text1
            // 
            this.ball_position_text1.AutoSize = true;
            this.ball_position_text1.Font = new System.Drawing.Font("Bauhaus 93", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ball_position_text1.ForeColor = System.Drawing.Color.White;
            this.ball_position_text1.Location = new System.Drawing.Point(12, 9);
            this.ball_position_text1.Name = "ball_position_text1";
            this.ball_position_text1.Size = new System.Drawing.Size(192, 32);
            this.ball_position_text1.TabIndex = 18;
            this.ball_position_text1.Text = "Snake-Pos. X:";
            // 
            // ballY
            // 
            this.ballY.AutoSize = true;
            this.ballY.Font = new System.Drawing.Font("Bauhaus 93", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballY.ForeColor = System.Drawing.Color.White;
            this.ballY.Location = new System.Drawing.Point(202, 41);
            this.ballY.Name = "ballY";
            this.ballY.Size = new System.Drawing.Size(31, 32);
            this.ballY.TabIndex = 17;
            this.ballY.Text = "0";
            // 
            // ball_position_text2
            // 
            this.ball_position_text2.AutoSize = true;
            this.ball_position_text2.Font = new System.Drawing.Font("Bauhaus 93", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ball_position_text2.ForeColor = System.Drawing.Color.White;
            this.ball_position_text2.Location = new System.Drawing.Point(12, 41);
            this.ball_position_text2.Name = "ball_position_text2";
            this.ball_position_text2.Size = new System.Drawing.Size(192, 32);
            this.ball_position_text2.TabIndex = 16;
            this.ball_position_text2.Text = "Snake-Pos. Y:";
            // 
            // eingabe_ausgabe
            // 
            this.eingabe_ausgabe.AutoSize = true;
            this.eingabe_ausgabe.Font = new System.Drawing.Font("Bauhaus 93", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_ausgabe.ForeColor = System.Drawing.Color.White;
            this.eingabe_ausgabe.Location = new System.Drawing.Point(151, 623);
            this.eingabe_ausgabe.Name = "eingabe_ausgabe";
            this.eingabe_ausgabe.Size = new System.Drawing.Size(31, 32);
            this.eingabe_ausgabe.TabIndex = 21;
            this.eingabe_ausgabe.Text = "0";
            // 
            // eingabe_text
            // 
            this.eingabe_text.AutoSize = true;
            this.eingabe_text.Font = new System.Drawing.Font("Bauhaus 93", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_text.ForeColor = System.Drawing.Color.White;
            this.eingabe_text.Location = new System.Drawing.Point(12, 623);
            this.eingabe_text.Name = "eingabe_text";
            this.eingabe_text.Size = new System.Drawing.Size(133, 32);
            this.eingabe_text.TabIndex = 20;
            this.eingabe_text.Text = "Eingabe:";
            // 
            // foodTimer
            // 
            this.foodTimer.Enabled = true;
            this.foodTimer.Interval = 5000;
            this.foodTimer.Tick += new System.EventHandler(this.foodTimer_Tick);
            // 
            // punkteAnzeige
            // 
            this.punkteAnzeige.AutoSize = true;
            this.punkteAnzeige.Font = new System.Drawing.Font("Bauhaus 93", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punkteAnzeige.ForeColor = System.Drawing.Color.White;
            this.punkteAnzeige.Location = new System.Drawing.Point(202, 73);
            this.punkteAnzeige.Name = "punkteAnzeige";
            this.punkteAnzeige.Size = new System.Drawing.Size(31, 32);
            this.punkteAnzeige.TabIndex = 23;
            this.punkteAnzeige.Text = "0";
            // 
            // punkteText
            // 
            this.punkteText.AutoSize = true;
            this.punkteText.Font = new System.Drawing.Font("Bauhaus 93", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punkteText.ForeColor = System.Drawing.Color.White;
            this.punkteText.Location = new System.Drawing.Point(12, 73);
            this.punkteText.Name = "punkteText";
            this.punkteText.Size = new System.Drawing.Size(118, 32);
            this.punkteText.TabIndex = 22;
            this.punkteText.Text = "Punkte:";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.punkteAnzeige);
            this.Controls.Add(this.punkteText);
            this.Controls.Add(this.eingabe_ausgabe);
            this.Controls.Add(this.eingabe_text);
            this.Controls.Add(this.ballX);
            this.Controls.Add(this.ball_position_text1);
            this.Controls.Add(this.ballY);
            this.Controls.Add(this.ball_position_text2);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "game";
            this.Text = "Das tolle Spiel Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.game_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ballX;
        private System.Windows.Forms.Label ball_position_text1;
        private System.Windows.Forms.Label ballY;
        private System.Windows.Forms.Label ball_position_text2;
        private System.Windows.Forms.Label eingabe_ausgabe;
        private System.Windows.Forms.Label eingabe_text;
        private System.Windows.Forms.Timer foodTimer;
        private System.Windows.Forms.Label punkteAnzeige;
        private System.Windows.Forms.Label punkteText;
    }
}