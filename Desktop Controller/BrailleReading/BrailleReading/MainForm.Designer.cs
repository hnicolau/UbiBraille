namespace BrailleReading
{
    partial class MainForm
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
            this.lbReceived = new System.Windows.Forms.Label();
            this.tbSentence = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.cbLeftRing = new System.Windows.Forms.CheckBox();
            this.cbLeftMiddle = new System.Windows.Forms.CheckBox();
            this.cbLeftIndex = new System.Windows.Forms.CheckBox();
            this.cbRightIndex = new System.Windows.Forms.CheckBox();
            this.cbRightMiddle = new System.Windows.Forms.CheckBox();
            this.cbRightRing = new System.Windows.Forms.CheckBox();
            this.btSendFingers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numUDRightRing = new System.Windows.Forms.NumericUpDown();
            this.numUDRightMiddle = new System.Windows.Forms.NumericUpDown();
            this.numUDRightIndex = new System.Windows.Forms.NumericUpDown();
            this.numUDLeftIndex = new System.Windows.Forms.NumericUpDown();
            this.numUDLeftMiddle = new System.Windows.Forms.NumericUpDown();
            this.numUDLeftRing = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numUDInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numUDDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRightRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRightMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRightIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLeftIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLeftMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLeftRing)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // lbReceived
            // 
            this.lbReceived.AutoSize = true;
            this.lbReceived.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReceived.Location = new System.Drawing.Point(168, 345);
            this.lbReceived.Name = "lbReceived";
            this.lbReceived.Size = new System.Drawing.Size(49, 13);
            this.lbReceived.TabIndex = 1;
            this.lbReceived.Text = "received";
            // 
            // tbSentence
            // 
            this.tbSentence.Location = new System.Drawing.Point(6, 55);
            this.tbSentence.Name = "tbSentence";
            this.tbSentence.Size = new System.Drawing.Size(403, 24);
            this.tbSentence.TabIndex = 2;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(6, 85);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(403, 36);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Send Sentence";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // cbLeftRing
            // 
            this.cbLeftRing.AutoSize = true;
            this.cbLeftRing.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeftRing.Location = new System.Drawing.Point(8, 52);
            this.cbLeftRing.Name = "cbLeftRing";
            this.cbLeftRing.Size = new System.Drawing.Size(55, 21);
            this.cbLeftRing.TabIndex = 4;
            this.cbLeftRing.Text = "Ring";
            this.cbLeftRing.UseVisualStyleBackColor = true;
            // 
            // cbLeftMiddle
            // 
            this.cbLeftMiddle.AutoSize = true;
            this.cbLeftMiddle.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeftMiddle.Location = new System.Drawing.Point(69, 52);
            this.cbLeftMiddle.Name = "cbLeftMiddle";
            this.cbLeftMiddle.Size = new System.Drawing.Size(68, 21);
            this.cbLeftMiddle.TabIndex = 5;
            this.cbLeftMiddle.Text = "Middle";
            this.cbLeftMiddle.UseVisualStyleBackColor = true;
            // 
            // cbLeftIndex
            // 
            this.cbLeftIndex.AutoSize = true;
            this.cbLeftIndex.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLeftIndex.Location = new System.Drawing.Point(143, 52);
            this.cbLeftIndex.Name = "cbLeftIndex";
            this.cbLeftIndex.Size = new System.Drawing.Size(60, 21);
            this.cbLeftIndex.TabIndex = 6;
            this.cbLeftIndex.Text = "Index";
            this.cbLeftIndex.UseVisualStyleBackColor = true;
            // 
            // cbRightIndex
            // 
            this.cbRightIndex.AutoSize = true;
            this.cbRightIndex.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRightIndex.Location = new System.Drawing.Point(219, 52);
            this.cbRightIndex.Name = "cbRightIndex";
            this.cbRightIndex.Size = new System.Drawing.Size(60, 21);
            this.cbRightIndex.TabIndex = 9;
            this.cbRightIndex.Text = "Index";
            this.cbRightIndex.UseVisualStyleBackColor = true;
            // 
            // cbRightMiddle
            // 
            this.cbRightMiddle.AutoSize = true;
            this.cbRightMiddle.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRightMiddle.Location = new System.Drawing.Point(285, 52);
            this.cbRightMiddle.Name = "cbRightMiddle";
            this.cbRightMiddle.Size = new System.Drawing.Size(68, 21);
            this.cbRightMiddle.TabIndex = 8;
            this.cbRightMiddle.Text = "Middle";
            this.cbRightMiddle.UseVisualStyleBackColor = true;
            // 
            // cbRightRing
            // 
            this.cbRightRing.AutoSize = true;
            this.cbRightRing.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRightRing.Location = new System.Drawing.Point(359, 52);
            this.cbRightRing.Name = "cbRightRing";
            this.cbRightRing.Size = new System.Drawing.Size(55, 21);
            this.cbRightRing.TabIndex = 7;
            this.cbRightRing.Text = "Ring";
            this.cbRightRing.UseVisualStyleBackColor = true;
            // 
            // btSendFingers
            // 
            this.btSendFingers.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSendFingers.Location = new System.Drawing.Point(6, 109);
            this.btSendFingers.Name = "btSendFingers";
            this.btSendFingers.Size = new System.Drawing.Size(403, 36);
            this.btSendFingers.TabIndex = 10;
            this.btSendFingers.Text = "Send Signal";
            this.btSendFingers.UseVisualStyleBackColor = true;
            this.btSendFingers.Click += new System.EventHandler(this.btSendFingers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Left Hand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Right Hand";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUDRightRing);
            this.groupBox1.Controls.Add(this.numUDRightMiddle);
            this.groupBox1.Controls.Add(this.numUDRightIndex);
            this.groupBox1.Controls.Add(this.numUDLeftIndex);
            this.groupBox1.Controls.Add(this.numUDLeftMiddle);
            this.groupBox1.Controls.Add(this.numUDLeftRing);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbLeftRing);
            this.groupBox1.Controls.Add(this.cbLeftMiddle);
            this.groupBox1.Controls.Add(this.btSendFingers);
            this.groupBox1.Controls.Add(this.cbLeftIndex);
            this.groupBox1.Controls.Add(this.cbRightIndex);
            this.groupBox1.Controls.Add(this.cbRightRing);
            this.groupBox1.Controls.Add(this.cbRightMiddle);
            this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 196);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fingers";
            // 
            // numUDRightRing
            // 
            this.numUDRightRing.Location = new System.Drawing.Point(355, 79);
            this.numUDRightRing.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDRightRing.Name = "numUDRightRing";
            this.numUDRightRing.Size = new System.Drawing.Size(54, 24);
            this.numUDRightRing.TabIndex = 19;
            this.numUDRightRing.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // numUDRightMiddle
            // 
            this.numUDRightMiddle.Location = new System.Drawing.Point(285, 79);
            this.numUDRightMiddle.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDRightMiddle.Name = "numUDRightMiddle";
            this.numUDRightMiddle.Size = new System.Drawing.Size(54, 24);
            this.numUDRightMiddle.TabIndex = 18;
            this.numUDRightMiddle.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // numUDRightIndex
            // 
            this.numUDRightIndex.Location = new System.Drawing.Point(219, 79);
            this.numUDRightIndex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDRightIndex.Name = "numUDRightIndex";
            this.numUDRightIndex.Size = new System.Drawing.Size(54, 24);
            this.numUDRightIndex.TabIndex = 17;
            this.numUDRightIndex.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // numUDLeftIndex
            // 
            this.numUDLeftIndex.Location = new System.Drawing.Point(143, 79);
            this.numUDLeftIndex.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDLeftIndex.Name = "numUDLeftIndex";
            this.numUDLeftIndex.Size = new System.Drawing.Size(54, 24);
            this.numUDLeftIndex.TabIndex = 16;
            this.numUDLeftIndex.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // numUDLeftMiddle
            // 
            this.numUDLeftMiddle.Location = new System.Drawing.Point(76, 79);
            this.numUDLeftMiddle.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDLeftMiddle.Name = "numUDLeftMiddle";
            this.numUDLeftMiddle.Size = new System.Drawing.Size(54, 24);
            this.numUDLeftMiddle.TabIndex = 15;
            this.numUDLeftMiddle.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // numUDLeftRing
            // 
            this.numUDLeftRing.Location = new System.Drawing.Point(9, 79);
            this.numUDLeftRing.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numUDLeftRing.Name = "numUDLeftRing";
            this.numUDLeftRing.Size = new System.Drawing.Size(54, 24);
            this.numUDLeftRing.TabIndex = 14;
            this.numUDLeftRing.Value = new decimal(new int[] {
            125,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Stop All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numUDInterval);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numUDDuration);
            this.groupBox2.Controls.Add(this.tbSentence);
            this.groupBox2.Controls.Add(this.btSend);
            this.groupBox2.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 128);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sentence";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(212, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Interval:";
            // 
            // numUDInterval
            // 
            this.numUDInterval.Location = new System.Drawing.Point(285, 23);
            this.numUDInterval.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numUDInterval.Name = "numUDInterval";
            this.numUDInterval.Size = new System.Drawing.Size(103, 24);
            this.numUDInterval.TabIndex = 6;
            this.numUDInterval.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Duration:";
            // 
            // numUDDuration
            // 
            this.numUDDuration.Location = new System.Drawing.Point(79, 23);
            this.numUDDuration.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUDDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDDuration.Name = "numUDDuration";
            this.numUDDuration.Size = new System.Drawing.Size(103, 24);
            this.numUDDuration.TabIndex = 4;
            this.numUDDuration.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Received Message (debug):";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 369);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbReceived);
            this.Name = "MainForm";
            this.Text = "Braille Reading";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRightRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRightMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRightIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLeftIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLeftMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDLeftRing)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReceived;
        private System.Windows.Forms.TextBox tbSentence;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.CheckBox cbLeftRing;
        private System.Windows.Forms.CheckBox cbLeftMiddle;
        private System.Windows.Forms.CheckBox cbLeftIndex;
        private System.Windows.Forms.CheckBox cbRightIndex;
        private System.Windows.Forms.CheckBox cbRightMiddle;
        private System.Windows.Forms.CheckBox cbRightRing;
        private System.Windows.Forms.Button btSendFingers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numUDInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUDDuration;
        private System.Windows.Forms.NumericUpDown numUDLeftIndex;
        private System.Windows.Forms.NumericUpDown numUDLeftMiddle;
        private System.Windows.Forms.NumericUpDown numUDLeftRing;
        private System.Windows.Forms.NumericUpDown numUDRightRing;
        private System.Windows.Forms.NumericUpDown numUDRightMiddle;
        private System.Windows.Forms.NumericUpDown numUDRightIndex;
    }
}

