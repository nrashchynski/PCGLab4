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
            scalenum = new NumericUpDown();
            changeScaleLabel = new Label();
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)x1num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y1num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x2num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y2num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)x0num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)y0num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radiusnum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scalenum).BeginInit();
            SuspendLayout();
            // 
            // circlepanel
            // 
            circlepanel.Location = new Point(335, 42);
            circlepanel.Name = "circlepanel";
            circlepanel.Size = new Size(281, 179);
            circlepanel.TabIndex = 0;
            circlepanel.Paint += circlepanel_Paint;
            // 
            // bresenhampanel
            // 
            bresenhampanel.Location = new Point(14, 42);
            bresenhampanel.Name = "bresenhampanel";
            bresenhampanel.Size = new Size(281, 179);
            bresenhampanel.TabIndex = 1;
            bresenhampanel.Paint += bresenhampanel_Paint;
            // 
            // ddapanel
            // 
            ddapanel.Location = new Point(335, 289);
            ddapanel.Name = "ddapanel";
            ddapanel.Size = new Size(281, 179);
            ddapanel.TabIndex = 2;
            ddapanel.Paint += ddapanel_Paint;
            // 
            // naivepanel
            // 
            naivepanel.Location = new Point(14, 289);
            naivepanel.Name = "naivepanel";
            naivepanel.Size = new Size(281, 179);
            naivepanel.TabIndex = 3;
            naivepanel.Paint += naivepanel_Paint;
            // 
            // bresenhamlabel
            // 
            bresenhamlabel.AutoSize = true;
            bresenhamlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            bresenhamlabel.Location = new Point(14, 9);
            bresenhamlabel.Name = "bresenhamlabel";
            bresenhamlabel.Size = new Size(219, 28);
            bresenhamlabel.TabIndex = 0;
            bresenhamlabel.Text = "Bresenham Alghoritm";
            // 
            // circlelabel
            // 
            circlelabel.AutoSize = true;
            circlelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            circlelabel.Location = new Point(302, 9);
            circlelabel.Name = "circlelabel";
            circlelabel.Size = new Size(314, 28);
            circlelabel.TabIndex = 4;
            circlelabel.Text = "Bresenham Alghoritm For Circle";
            // 
            // naivelabel
            // 
            naivelabel.AutoSize = true;
            naivelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            naivelabel.Location = new Point(14, 258);
            naivelabel.Name = "naivelabel";
            naivelabel.Size = new Size(169, 28);
            naivelabel.TabIndex = 5;
            naivelabel.Text = "Naive Alghoritm";
            // 
            // ddalabel
            // 
            ddalabel.AutoSize = true;
            ddalabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ddalabel.Location = new Point(335, 258);
            ddalabel.Name = "ddalabel";
            ddalabel.Size = new Size(158, 28);
            ddalabel.TabIndex = 6;
            ddalabel.Text = "DDA Alghoritm";
            // 
            // rastLineButton
            // 
            rastLineButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rastLineButton.Location = new Point(710, 86);
            rastLineButton.Name = "rastLineButton";
            rastLineButton.Size = new Size(220, 34);
            rastLineButton.TabIndex = 7;
            rastLineButton.Text = "Rasterize Line";
            rastLineButton.UseVisualStyleBackColor = true;
            rastLineButton.Click += rastLineButton_Click;
            // 
            // x1num
            // 
            x1num.Location = new Point(744, 19);
            x1num.Name = "x1num";
            x1num.Size = new Size(72, 27);
            x1num.TabIndex = 10;
            // 
            // y1num
            // 
            y1num.Location = new Point(744, 52);
            y1num.Name = "y1num";
            y1num.Size = new Size(72, 27);
            y1num.TabIndex = 11;
            // 
            // x2num
            // 
            x2num.Location = new Point(858, 20);
            x2num.Name = "x2num";
            x2num.Size = new Size(72, 27);
            x2num.TabIndex = 15;
            // 
            // y2num
            // 
            y2num.Location = new Point(858, 53);
            y2num.Name = "y2num";
            y2num.Size = new Size(72, 27);
            y2num.TabIndex = 16;
            // 
            // x0num
            // 
            x0num.Location = new Point(744, 141);
            x0num.Name = "x0num";
            x0num.Size = new Size(72, 27);
            x0num.TabIndex = 19;
            // 
            // y0num
            // 
            y0num.Location = new Point(745, 174);
            y0num.Name = "y0num";
            y0num.Size = new Size(72, 27);
            y0num.TabIndex = 20;
            // 
            // radiusnum
            // 
            radiusnum.Location = new Point(858, 142);
            radiusnum.Name = "radiusnum";
            radiusnum.Size = new Size(72, 27);
            radiusnum.TabIndex = 22;
            // 
            // rastCircleButton
            // 
            rastCircleButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rastCircleButton.Location = new Point(710, 207);
            rastCircleButton.Name = "rastCircleButton";
            rastCircleButton.Size = new Size(220, 34);
            rastCircleButton.TabIndex = 23;
            rastCircleButton.Text = "Rasterize Circle";
            rastCircleButton.UseVisualStyleBackColor = true;
            rastCircleButton.Click += rastCircleButton_Click;
            // 
            // scalenum
            // 
            scalenum.Location = new Point(733, 349);
            scalenum.Name = "scalenum";
            scalenum.Size = new Size(72, 27);
            scalenum.TabIndex = 24;
            // 
            // changeScaleLabel
            // 
            changeScaleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            changeScaleLabel.Location = new Point(733, 390);
            changeScaleLabel.Name = "changeScaleLabel";
            changeScaleLabel.Size = new Size(141, 44);
            changeScaleLabel.TabIndex = 26;
            changeScaleLabel.Text = "Change Scale";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(710, 19);
            label5.Name = "label5";
            label5.Size = new Size(29, 27);
            label5.TabIndex = 8;
            label5.Text = "x1";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(710, 52);
            label6.Name = "label6";
            label6.Size = new Size(29, 27);
            label6.TabIndex = 9;
            label6.Text = "y1";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(822, 20);
            label8.Name = "label8";
            label8.Size = new Size(29, 27);
            label8.TabIndex = 13;
            label8.Text = "x2";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(822, 53);
            label9.Name = "label9";
            label9.Size = new Size(29, 27);
            label9.TabIndex = 14;
            label9.Text = "y2";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label10.Location = new Point(710, 141);
            label10.Name = "label10";
            label10.Size = new Size(29, 27);
            label10.TabIndex = 17;
            label10.Text = "x0";
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label11.Location = new Point(710, 174);
            label11.Name = "label11";
            label11.Size = new Size(29, 27);
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
            bresenham_vScrollBar.Location = new Point(298, 42);
            bresenham_vScrollBar.Maximum = 50;
            bresenham_vScrollBar.Minimum = -50;
            bresenham_vScrollBar.Name = "bresenham_vScrollBar";
            bresenham_vScrollBar.Size = new Size(26, 179);
            bresenham_vScrollBar.TabIndex = 27;
            bresenham_vScrollBar.Scroll += bresenham_vScrollBar_Scroll;
            // 
            // circle_vScrollBar
            // 
            circle_vScrollBar.Location = new Point(619, 42);
            circle_vScrollBar.Maximum = 50;
            circle_vScrollBar.Minimum = -50;
            circle_vScrollBar.Name = "circle_vScrollBar";
            circle_vScrollBar.Size = new Size(26, 179);
            circle_vScrollBar.TabIndex = 28;
            circle_vScrollBar.Scroll += circle_vScrollBar_Scroll;
            // 
            // dda_vScrollBar
            // 
            dda_vScrollBar.Location = new Point(619, 289);
            dda_vScrollBar.Maximum = 50;
            dda_vScrollBar.Minimum = -50;
            dda_vScrollBar.Name = "dda_vScrollBar";
            dda_vScrollBar.Size = new Size(26, 179);
            dda_vScrollBar.TabIndex = 29;
            dda_vScrollBar.Scroll += dda_vScrollBar_Scroll;
            // 
            // naive_vScrollBar
            // 
            naive_vScrollBar.Location = new Point(298, 274);
            naive_vScrollBar.Maximum = 50;
            naive_vScrollBar.Minimum = -50;
            naive_vScrollBar.Name = "naive_vScrollBar";
            naive_vScrollBar.Size = new Size(26, 179);
            naive_vScrollBar.TabIndex = 30;
            naive_vScrollBar.Scroll += naive_vScrollBar_Scroll;
            // 
            // bresenham_hScrollBar
            // 
            bresenham_hScrollBar.Location = new Point(18, 225);
            bresenham_hScrollBar.Maximum = 50;
            bresenham_hScrollBar.Minimum = -50;
            bresenham_hScrollBar.Name = "bresenham_hScrollBar";
            bresenham_hScrollBar.Size = new Size(277, 26);
            bresenham_hScrollBar.TabIndex = 31;
            bresenham_hScrollBar.Scroll += bresenham_hScrollBar_Scroll;
            // 
            // circle_hScrollBar
            // 
            circle_hScrollBar.Location = new Point(335, 232);
            circle_hScrollBar.Maximum = 50;
            circle_hScrollBar.Minimum = -50;
            circle_hScrollBar.Name = "circle_hScrollBar";
            circle_hScrollBar.Size = new Size(277, 26);
            circle_hScrollBar.TabIndex = 32;
            circle_hScrollBar.Scroll += circle_hScrollBar_Scroll;
            // 
            // naive_hScrollBar
            // 
            naive_hScrollBar.Location = new Point(14, 475);
            naive_hScrollBar.Maximum = 50;
            naive_hScrollBar.Minimum = -50;
            naive_hScrollBar.Name = "naive_hScrollBar";
            naive_hScrollBar.Size = new Size(277, 26);
            naive_hScrollBar.TabIndex = 33;
            naive_hScrollBar.Scroll += naive_hScrollBar_Scroll;
            // 
            // dda_hScrollBar
            // 
            dda_hScrollBar.Location = new Point(335, 475);
            dda_hScrollBar.Maximum = 50;
            dda_hScrollBar.Minimum = -50;
            dda_hScrollBar.Name = "dda_hScrollBar";
            dda_hScrollBar.Size = new Size(277, 26);
            dda_hScrollBar.TabIndex = 34;
            dda_hScrollBar.Scroll += dda_hScrollBar_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(822, 349);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 35;
            button1.Text = "Change Scale";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 510);
            Controls.Add(button1);
            Controls.Add(dda_hScrollBar);
            Controls.Add(naive_hScrollBar);
            Controls.Add(circle_hScrollBar);
            Controls.Add(bresenham_hScrollBar);
            Controls.Add(naive_vScrollBar);
            Controls.Add(dda_vScrollBar);
            Controls.Add(circle_vScrollBar);
            Controls.Add(bresenham_vScrollBar);
            Controls.Add(changeScaleLabel);
            Controls.Add(scalenum);
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
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Rasterizer App";
            ((System.ComponentModel.ISupportInitialize)x1num).EndInit();
            ((System.ComponentModel.ISupportInitialize)y1num).EndInit();
            ((System.ComponentModel.ISupportInitialize)x2num).EndInit();
            ((System.ComponentModel.ISupportInitialize)y2num).EndInit();
            ((System.ComponentModel.ISupportInitialize)x0num).EndInit();
            ((System.ComponentModel.ISupportInitialize)y0num).EndInit();
            ((System.ComponentModel.ISupportInitialize)radiusnum).EndInit();
            ((System.ComponentModel.ISupportInitialize)scalenum).EndInit();
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
        private NumericUpDown scalenum;
        private Label label13;
        private Label changeScaleLabel;
        private VScrollBar bresenham_vScrollBar;
        private VScrollBar circle_vScrollBar;
        private VScrollBar dda_vScrollBar;
        private VScrollBar naive_vScrollBar;
        private HScrollBar bresenham_hScrollBar;
        private HScrollBar circle_hScrollBar;
        private HScrollBar naive_hScrollBar;
        private HScrollBar dda_hScrollBar;
        private Button button1;
    }
}
