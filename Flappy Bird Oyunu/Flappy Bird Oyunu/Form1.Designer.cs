namespace Flappy_Bird_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Boru_Ust = new System.Windows.Forms.PictureBox();
            this.Boru_Alt = new System.Windows.Forms.PictureBox();
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.Zemin = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Boru_Ust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boru_Alt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).BeginInit();
            this.SuspendLayout();
            // 
            // Boru_Ust
            // 
            this.Boru_Ust.Image = ((System.Drawing.Image)(resources.GetObject("Boru_Ust.Image")));
            this.Boru_Ust.Location = new System.Drawing.Point(645, 12);
            this.Boru_Ust.Name = "Boru_Ust";
            this.Boru_Ust.Size = new System.Drawing.Size(100, 185);
            this.Boru_Ust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Boru_Ust.TabIndex = 0;
            this.Boru_Ust.TabStop = false;
            // 
            // Boru_Alt
            // 
            this.Boru_Alt.Image = ((System.Drawing.Image)(resources.GetObject("Boru_Alt.Image")));
            this.Boru_Alt.Location = new System.Drawing.Point(483, 319);
            this.Boru_Alt.Name = "Boru_Alt";
            this.Boru_Alt.Size = new System.Drawing.Size(100, 149);
            this.Boru_Alt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Boru_Alt.TabIndex = 0;
            this.Boru_Alt.TabStop = false;
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = ((System.Drawing.Image)(resources.GetObject("FlappyBird.Image")));
            this.FlappyBird.Location = new System.Drawing.Point(79, 131);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(100, 50);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FlappyBird.TabIndex = 0;
            this.FlappyBird.TabStop = false;
            // 
            // Zemin
            // 
            this.Zemin.Image = ((System.Drawing.Image)(resources.GetObject("Zemin.Image")));
            this.Zemin.Location = new System.Drawing.Point(12, 474);
            this.Zemin.Name = "Zemin";
            this.Zemin.Size = new System.Drawing.Size(807, 98);
            this.Zemin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zemin.TabIndex = 0;
            this.Zemin.TabStop = false;
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ScoreText.Location = new System.Drawing.Point(42, 522);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(88, 25);
            this.ScoreText.TabIndex = 1;
            this.ScoreText.Text = "Score:0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(831, 584);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Zemin);
            this.Controls.Add(this.Boru_Alt);
            this.Controls.Add(this.Boru_Ust);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Boru_Ust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boru_Alt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Zemin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Boru_Ust;
        private System.Windows.Forms.PictureBox Boru_Alt;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.PictureBox Zemin;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}

