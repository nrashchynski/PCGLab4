using System.Windows.Forms;

namespace PCGLab4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            circlepanel = new Panel();
            bresenhampanel = new Panel();
            ddapanel = new Panel();
            naivepanel = new Panel();
            bresenhamlabel = new Label();
            circlelabel = new Label();
            naivelabel = new Label();
            ddalabel = new Label();
            rastLineButton = new Button();
            x1num = new NumericUpDown();
            y1num = new NumericUpDown();
            x2num = new NumericUpDown();
            y2num = new NumericUpDown();
            x0num = new NumericUpDown();
            y0num = new NumericUpDown();
            radiusnum = new NumericUpDown();
            rastCircleButton = new Button();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            bresenham_vScrollBar = new VScrollBar();
            circle_vScrollBar = new VScrollBar();
            dda_vScrollBar = new VScrollBar();
            naive_vScrollBar = new VScrollBar();
            bresenham_hScrollBar = new HScrollBar();
            circle_hScrollBar = new HScrollBar();
            naive_hScrollBar = new HScrollBar();
            dda_hScrollBar = new HScrollBar();
            Rlabel = new Label();
            bresenhamtime_label = new Label();
            circletime_label = new Label();
            naivetime_label = new Label();
            ddatime_label = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)x1num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y1num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x2num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y2num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x0num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y0num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radiusnum).BeginInit();
            SuspendLayout();
            // 
            // circlepanel
            // 
            circlepanel.Location = new Point(298, 39);
            circlepanel.Name = "circlepanel";
            circlepanel.Size = new Size(250, 149);
            circlepanel.TabIndex = 0;
            circlepanel.Paint += circlepanel_Paint;
            // 
            // bresenhampanel
            // 
            bresenhampanel.Location = new Point(12, 39);
            bresenhampanel.Name = "bresenhampanel";
            bresenhampanel.Size = new Size(250, 149);
            bresenhampanel.TabIndex = 1;
            bresenhampanel.Paint += bresenhampanel_Paint;
            // 
            // ddapanel
            // 
            ddapanel.Location = new Point(298, 250);
            ddapanel.Name = "ddapanel";
            ddapanel.Size = new Size(250, 148);
            ddapanel.TabIndex = 2;
            ddapanel.Paint += ddapanel_Paint;
            // 
            // naivepanel
            // 
            naivepanel.Location = new Point(12, 250);
            naivepanel.Name = "naivepanel";
            naivepanel.Size = new Size(250, 148);
            naivepanel.TabIndex = 3;
            naivepanel.Paint += naivepanel_Paint;
            // 
            // bresenhamlabel
            // 
            bresenhamlabel.AutoSize = true;
            bresenhamlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bresenhamlabel.Location = new Point(12, 8);
            bresenhamlabel.Name = "bresenhamlabel";
            bresenhamlabel.Size = new Size(219, 28);
            bresenhamlabel.TabIndex = 0;
            bresenhamlabel.Text = "Bresenham Alghoritm";
            // 
            // circlelabel
            // 
            circlelabel.AutoSize = true;
            circlelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            circlelabel.Location = new Point(268, 8);
            circlelabel.Name = "circlelabel";
            circlelabel.Size = new Size(314, 28);
            circlelabel.TabIndex = 4;
            circlelabel.Text = "Bresenham Alghoritm For Circle";
            // 
            // naivelabel
            // 
            naivelabel.AutoSize = true;
            naivelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            naivelabel.Location = new Point(12, 219);
            naivelabel.Name = "naivelabel";
            naivelabel.Size = new Size(169, 28);
            naivelabel.TabIndex = 5;
            naivelabel.Text = "Naive Alghoritm";
            // 
            // ddalabel
            // 
            ddalabel.AutoSize = true;
            ddalabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ddalabel.Location = new Point(298, 219);
            ddalabel.Name = "ddalabel";
            ddalabel.Size = new Size(158, 28);
            ddalabel.TabIndex = 6;
            ddalabel.Text = "DDA Alghoritm";
            // 
            // rastLineButton
            // 
            rastLineButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rastLineButton.Location = new Point(631, 73);
            rastLineButton.Name = "rastLineButton";
            rastLineButton.Size = new Size(196, 41);
            rastLineButton.TabIndex = 7;
            rastLineButton.Text = "Rasterize Line";
            rastLineButton.UseVisualStyleBackColor = true;
            rastLineButton.Click += rastLineButton_Click;
            // 
            // x1num
            // 
            x1num.Location = new Point(661, 16);
            x1num.Name = "x1num";
            x1num.Size = new Size(64, 23);
            x1num.TabIndex = 10;
            // 
            // y1num
            // 
            y1num.Location = new Point(661, 44);
            y1num.Name = "y1num";
            y1num.Size = new Size(64, 23);
            y1num.TabIndex = 11;
            // 
            // x2num
            // 
            x2num.Location = new Point(763, 17);
            x2num.Name = "x2num";
            x2num.Size = new Size(64, 23);
            x2num.TabIndex = 15;
            // 
            // y2num
            // 
            y2num.Location = new Point(763, 45);
            y2num.Name = "y2num";
            y2num.Size = new Size(64, 23);
            y2num.TabIndex = 16;
            // 
            // x0num
            // 
            x0num.Location = new Point(661, 120);
            x0num.Name = "x0num";
            x0num.Size = new Size(64, 23);
            x0num.TabIndex = 19;
            // 
            // y0num
            // 
            y0num.Location = new Point(662, 148);
            y0num.Name = "y0num";
            y0num.Size = new Size(64, 23);
            y0num.TabIndex = 20;
            // 
            // radiusnum
            // 
            radiusnum.Location = new Point(763, 121);
            radiusnum.Name = "radiusnum";
            radiusnum.Size = new Size(64, 23);
            radiusnum.TabIndex = 22;
            // 
            // rastCircleButton
            // 
            rastCircleButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rastCircleButton.Location = new Point(631, 176);
            rastCircleButton.Name = "rastCircleButton";
            rastCircleButton.Size = new Size(196, 41);
            rastCircleButton.TabIndex = 23;
            rastCircleButton.Text = "Rasterize Circle";
            rastCircleButton.UseVisualStyleBackColor = true;
            rastCircleButton.Click += rastCircleButton_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(631, 16);
            label5.Name = "label5";
            label5.Size = new Size(26, 23);
            label5.TabIndex = 8;
            label5.Text = "x1";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(631, 44);
            label6.Name = "label6";
            label6.Size = new Size(26, 23);
            label6.TabIndex = 9;
            label6.Text = "y1";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(731, 17);
            label8.Name = "label8";
            label8.Size = new Size(26, 23);
            label8.TabIndex = 13;
            label8.Text = "x2";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(731, 45);
            label9.Name = "label9";
            label9.Size = new Size(26, 23);
            label9.TabIndex = 14;
            label9.Text = "y2";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label10.Location = new Point(631, 120);
            label10.Name = "label10";
            label10.Size = new Size(26, 23);
            label10.TabIndex = 17;
            label10.Text = "x0";
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(631, 148);
            label11.Name = "label11";
            label11.Size = new Size(26, 23);
            label11.TabIndex = 18;
            label11.Text = "y0";
            // 
            // label12
            // 
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 0;
            // 
            // bresenham_vScrollBar
            // 
            bresenham_vScrollBar.Location = new Point(265, 36);
            bresenham_vScrollBar.Maximum = 50;
            bresenham_vScrollBar.Minimum = -50;
            bresenham_vScrollBar.Name = "bresenham_vScrollBar";
            bresenham_vScrollBar.Size = new Size(26, 152);
            bresenham_vScrollBar.TabIndex = 27;
            bresenham_vScrollBar.Scroll += bresenham_vScrollBar_Scroll;
            // 
            // circle_vScrollBar
            // 
            circle_vScrollBar.Location = new Point(550, 36);
            circle_vScrollBar.Maximum = 50;
            circle_vScrollBar.Minimum = -50;
            circle_vScrollBar.Name = "circle_vScrollBar";
            circle_vScrollBar.Size = new Size(26, 152);
            circle_vScrollBar.TabIndex = 28;
            circle_vScrollBar.Scroll += circle_vScrollBar_Scroll;
            // 
            // dda_vScrollBar
            // 
            dda_vScrollBar.Location = new Point(550, 246);
            dda_vScrollBar.Maximum = 50;
            dda_vScrollBar.Minimum = -50;
            dda_vScrollBar.Name = "dda_vScrollBar";
            dda_vScrollBar.Size = new Size(26, 152);
            dda_vScrollBar.TabIndex = 29;
            dda_vScrollBar.Scroll += dda_vScrollBar_Scroll;
            // 
            // naive_vScrollBar
            // 
            naive_vScrollBar.Location = new Point(265, 233);
            naive_vScrollBar.Maximum = 50;
            naive_vScrollBar.Minimum = -50;
            naive_vScrollBar.Name = "naive_vScrollBar";
            naive_vScrollBar.Size = new Size(26, 152);
            naive_vScrollBar.TabIndex = 30;
            naive_vScrollBar.Scroll += naive_vScrollBar_Scroll;
            // 
            // bresenham_hScrollBar
            // 
            bresenham_hScrollBar.Location = new Point(16, 191);
            bresenham_hScrollBar.Maximum = 50;
            bresenham_hScrollBar.Minimum = -50;
            bresenham_hScrollBar.Name = "bresenham_hScrollBar";
            bresenham_hScrollBar.Size = new Size(246, 26);
            bresenham_hScrollBar.TabIndex = 31;
            bresenham_hScrollBar.Scroll += bresenham_hScrollBar_Scroll;
            // 
            // circle_hScrollBar
            // 
            circle_hScrollBar.Location = new Point(298, 197);
            circle_hScrollBar.Maximum = 50;
            circle_hScrollBar.Minimum = -50;
            circle_hScrollBar.Name = "circle_hScrollBar";
            circle_hScrollBar.Size = new Size(246, 26);
            circle_hScrollBar.TabIndex = 32;
            circle_hScrollBar.Scroll += circle_hScrollBar_Scroll;
            // 
            // naive_hScrollBar
            // 
            naive_hScrollBar.Location = new Point(12, 404);
            naive_hScrollBar.Maximum = 50;
            naive_hScrollBar.Minimum = -50;
            naive_hScrollBar.Name = "naive_hScrollBar";
            naive_hScrollBar.Size = new Size(246, 26);
            naive_hScrollBar.TabIndex = 33;
            naive_hScrollBar.Scroll += naive_hScrollBar_Scroll;
            // 
            // dda_hScrollBar
            // 
            dda_hScrollBar.Location = new Point(298, 404);
            dda_hScrollBar.Maximum = 50;
            dda_hScrollBar.Minimum = -50;
            dda_hScrollBar.Name = "dda_hScrollBar";
            dda_hScrollBar.Size = new Size(246, 26);
            dda_hScrollBar.TabIndex = 34;
            dda_hScrollBar.Scroll += dda_hScrollBar_Scroll;
            // 
            // Rlabel
            // 
            Rlabel.BackColor = Color.Transparent;
            Rlabel.BorderStyle = BorderStyle.FixedSingle;
            Rlabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Rlabel.Location = new Point(731, 122);
            Rlabel.Name = "Rlabel";
            Rlabel.Size = new Size(26, 23);
            Rlabel.TabIndex = 36;
            Rlabel.Text = "R";
            // 
            // bresenhamtime_label
            // 
            bresenhamtime_label.BackColor = SystemColors.ActiveCaption;
            bresenhamtime_label.Location = new Point(693, 250);
            bresenhamtime_label.Name = "bresenhamtime_label";
            bresenhamtime_label.Size = new Size(133, 29);
            bresenhamtime_label.TabIndex = 37;
            bresenhamtime_label.Click += bresenhamtime_label_Click;
            // 
            // circletime_label
            // 
            circletime_label.BackColor = SystemColors.ActiveCaption;
            circletime_label.Location = new Point(693, 289);
            circletime_label.Name = "circletime_label";
            circletime_label.Size = new Size(133, 29);
            circletime_label.TabIndex = 38;
            // 
            // naivetime_label
            // 
            naivetime_label.BackColor = SystemColors.ActiveCaption;
            naivetime_label.Location = new Point(693, 327);
            naivetime_label.Name = "naivetime_label";
            naivetime_label.Size = new Size(133, 29);
            naivetime_label.TabIndex = 39;
            // 
            // ddatime_label
            // 
            ddatime_label.BackColor = SystemColors.ActiveCaption;
            ddatime_label.Location = new Point(693, 365);
            ddatime_label.Name = "ddatime_label";
            ddatime_label.Size = new Size(133, 29);
            ddatime_label.TabIndex = 40;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(631, 250);
            label2.Name = "label2";
            label2.Size = new Size(46, 29);
            label2.TabIndex = 41;
            label2.Text = "BA";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(631, 289);
            label3.Name = "label3";
            label3.Size = new Size(46, 29);
            label3.TabIndex = 42;
            label3.Text = "BAC";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(631, 327);
            label4.Name = "label4";
            label4.Size = new Size(46, 29);
            label4.TabIndex = 43;
            label4.Text = "NA";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(631, 365);
            label1.Name = "label1";
            label1.Size = new Size(46, 29);
            label1.TabIndex = 44;
            label1.Text = "DDA";
            // 
            // label7
            // 
            label7.BackColor = SystemColors.Control;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(683, 404);
            label7.Name = "label7";
            label7.Size = new Size(42, 17);
            label7.TabIndex = 45;
            label7.Text = "Time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 434);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ddatime_label);
            Controls.Add(naivetime_label);
            Controls.Add(circletime_label);
            Controls.Add(bresenhamtime_label);
            Controls.Add(Rlabel);
            Controls.Add(dda_hScrollBar);
            Controls.Add(naive_hScrollBar);
            Controls.Add(circle_hScrollBar);
            Controls.Add(bresenham_hScrollBar);
            Controls.Add(naive_vScrollBar);
            Controls.Add(dda_vScrollBar);
            Controls.Add(circle_vScrollBar);
            Controls.Add(bresenham_vScrollBar);
            Controls.Add(rastCircleButton);
            Controls.Add(radiusnum);
            Controls.Add(y0num);
            Controls.Add(x0num);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(y2num);
            Controls.Add(x2num);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(y1num);
            Controls.Add(x1num);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rastLineButton);
            Controls.Add(ddalabel);
            Controls.Add(naivelabel);
            Controls.Add(circlelabel);
            Controls.Add(bresenhamlabel);
            Controls.Add(naivepanel);
            Controls.Add(ddapanel);
            Controls.Add(bresenhampanel);
            Controls.Add(circlepanel);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Name = "Form1";
            Text = "Rasterizer App";
            ((System.ComponentModel.ISupportInitialize)x1num).EndInit();
            ((System.ComponentModel.ISupportInitialize)y1num).EndInit();
            ((System.ComponentModel.ISupportInitialize)x2num).EndInit();
            ((System.ComponentModel.ISupportInitialize)y2num).EndInit();
            ((System.ComponentModel.ISupportInitialize)x0num).EndInit();
            ((System.ComponentModel.ISupportInitialize)y0num).EndInit();
            ((System.ComponentModel.ISupportInitialize)radiusnum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel circlepanel;
        private Panel bresenhampanel;
        private Panel ddapanel;
        private Panel naivepanel;
        private Label bresenhamlabel;
        private Label circlelabel;
        private Label naivelabel;
        private Label ddalabel;
        private Button rastLineButton;
        private Label label5;
        private Label label6;
        private NumericUpDown x1num;
        private NumericUpDown y1num;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown x2num;
        private NumericUpDown y2num;
        private Label label10;
        private Label label11;
        private NumericUpDown x0num;
        private NumericUpDown y0num;
        private Label label12;
        private NumericUpDown radiusnum;
        private Button rastCircleButton;
        private Label label13;
        private VScrollBar bresenham_vScrollBar;
        private VScrollBar circle_vScrollBar;
        private VScrollBar dda_vScrollBar;
        private VScrollBar naive_vScrollBar;
        private HScrollBar bresenham_hScrollBar;
        private HScrollBar circle_hScrollBar;
        private HScrollBar naive_hScrollBar;
        private HScrollBar dda_hScrollBar;
        private Label Rlabel;
        private Label bresenhamtime_label;
        private Label circletime_label;
        private Label naivetime_label;
        private Label ddatime_label;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}
