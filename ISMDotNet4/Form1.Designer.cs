namespace ISMDotNet4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSumNegArrElems = new System.Windows.Forms.Label();
            this.labelMaxArrElem = new System.Windows.Forms.Label();
            this.labelSumIndexesPositiveArrElems = new System.Windows.Forms.Label();
            this.labelQuantityIntArrElems = new System.Windows.Forms.Label();
            this.labelSortedArrDecreasing = new System.Windows.Forms.Label();
            this.labelDeletedNegArrElems = new System.Windows.Forms.Label();
            this.textBoxSumNegArrElems = new System.Windows.Forms.TextBox();
            this.textBoxMaxArrElem = new System.Windows.Forms.TextBox();
            this.textBoxSumIndexesPositiveArrElems = new System.Windows.Forms.TextBox();
            this.textBoxQuantityIntArrElems = new System.Windows.Forms.TextBox();
            this.buttonSeeResults = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIndexMaxArrElem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaxModuleArrElem = new System.Windows.Forms.TextBox();
            this.dataGridViewSortedArr = new System.Windows.Forms.DataGridView();
            this.labelEnterArrSize = new System.Windows.Forms.Label();
            this.textBoxArrSize = new System.Windows.Forms.TextBox();
            this.dataGridViewArrayEntering = new System.Windows.Forms.DataGridView();
            this.buttonEnterArrSize = new System.Windows.Forms.Button();
            this.dataGridViewArrDeletedNegElem = new System.Windows.Forms.DataGridView();
            this.Author = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortedArr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayEntering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrDeletedNegElem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSumNegArrElems
            // 
            this.labelSumNegArrElems.AutoSize = true;
            this.labelSumNegArrElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumNegArrElems.Location = new System.Drawing.Point(16, 176);
            this.labelSumNegArrElems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumNegArrElems.Name = "labelSumNegArrElems";
            this.labelSumNegArrElems.Size = new System.Drawing.Size(230, 16);
            this.labelSumNegArrElems.TabIndex = 2;
            this.labelSumNegArrElems.Text = "Сума від\'ємних елементів масиву:";
            // 
            // labelMaxArrElem
            // 
            this.labelMaxArrElem.AutoSize = true;
            this.labelMaxArrElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxArrElem.Location = new System.Drawing.Point(16, 224);
            this.labelMaxArrElem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxArrElem.Name = "labelMaxArrElem";
            this.labelMaxArrElem.Size = new System.Drawing.Size(218, 16);
            this.labelMaxArrElem.TabIndex = 3;
            this.labelMaxArrElem.Text = "Максимальний елемент масиву:";
            // 
            // labelSumIndexesPositiveArrElems
            // 
            this.labelSumIndexesPositiveArrElems.AutoSize = true;
            this.labelSumIndexesPositiveArrElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumIndexesPositiveArrElems.Location = new System.Drawing.Point(16, 370);
            this.labelSumIndexesPositiveArrElems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSumIndexesPositiveArrElems.Name = "labelSumIndexesPositiveArrElems";
            this.labelSumIndexesPositiveArrElems.Size = new System.Drawing.Size(234, 16);
            this.labelSumIndexesPositiveArrElems.TabIndex = 4;
            this.labelSumIndexesPositiveArrElems.Text = "Сума індексів додатних елементів:";
            // 
            // labelQuantityIntArrElems
            // 
            this.labelQuantityIntArrElems.AutoSize = true;
            this.labelQuantityIntArrElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuantityIntArrElems.Location = new System.Drawing.Point(16, 413);
            this.labelQuantityIntArrElems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantityIntArrElems.Name = "labelQuantityIntArrElems";
            this.labelQuantityIntArrElems.Size = new System.Drawing.Size(203, 16);
            this.labelQuantityIntArrElems.TabIndex = 5;
            this.labelQuantityIntArrElems.Text = "Кількість цілих чисел у масиві:";
            // 
            // labelSortedArrDecreasing
            // 
            this.labelSortedArrDecreasing.AutoSize = true;
            this.labelSortedArrDecreasing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSortedArrDecreasing.Location = new System.Drawing.Point(16, 453);
            this.labelSortedArrDecreasing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSortedArrDecreasing.Name = "labelSortedArrDecreasing";
            this.labelSortedArrDecreasing.Size = new System.Drawing.Size(245, 16);
            this.labelSortedArrDecreasing.TabIndex = 6;
            this.labelSortedArrDecreasing.Text = "Відсортований масив за спаданням:";
            // 
            // labelDeletedNegArrElems
            // 
            this.labelDeletedNegArrElems.AutoSize = true;
            this.labelDeletedNegArrElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeletedNegArrElems.Location = new System.Drawing.Point(594, 453);
            this.labelDeletedNegArrElems.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDeletedNegArrElems.Name = "labelDeletedNegArrElems";
            this.labelDeletedNegArrElems.Size = new System.Drawing.Size(310, 16);
            this.labelDeletedNegArrElems.TabIndex = 7;
            this.labelDeletedNegArrElems.Text = "Масив із видаленими від\'ємними елементами:";
            // 
            // textBoxSumNegArrElems
            // 
            this.textBoxSumNegArrElems.Enabled = false;
            this.textBoxSumNegArrElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumNegArrElems.Location = new System.Drawing.Point(350, 166);
            this.textBoxSumNegArrElems.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSumNegArrElems.Name = "textBoxSumNegArrElems";
            this.textBoxSumNegArrElems.Size = new System.Drawing.Size(263, 26);
            this.textBoxSumNegArrElems.TabIndex = 8;
            // 
            // textBoxMaxArrElem
            // 
            this.textBoxMaxArrElem.Enabled = false;
            this.textBoxMaxArrElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxArrElem.Location = new System.Drawing.Point(350, 218);
            this.textBoxMaxArrElem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxArrElem.Name = "textBoxMaxArrElem";
            this.textBoxMaxArrElem.Size = new System.Drawing.Size(263, 26);
            this.textBoxMaxArrElem.TabIndex = 9;
            // 
            // textBoxSumIndexesPositiveArrElems
            // 
            this.textBoxSumIndexesPositiveArrElems.Enabled = false;
            this.textBoxSumIndexesPositiveArrElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSumIndexesPositiveArrElems.Location = new System.Drawing.Point(350, 360);
            this.textBoxSumIndexesPositiveArrElems.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSumIndexesPositiveArrElems.Name = "textBoxSumIndexesPositiveArrElems";
            this.textBoxSumIndexesPositiveArrElems.Size = new System.Drawing.Size(263, 26);
            this.textBoxSumIndexesPositiveArrElems.TabIndex = 10;
            // 
            // textBoxQuantityIntArrElems
            // 
            this.textBoxQuantityIntArrElems.Enabled = false;
            this.textBoxQuantityIntArrElems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQuantityIntArrElems.Location = new System.Drawing.Point(350, 403);
            this.textBoxQuantityIntArrElems.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantityIntArrElems.Name = "textBoxQuantityIntArrElems";
            this.textBoxQuantityIntArrElems.Size = new System.Drawing.Size(263, 26);
            this.textBoxQuantityIntArrElems.TabIndex = 11;
            // 
            // buttonSeeResults
            // 
            this.buttonSeeResults.Location = new System.Drawing.Point(597, 70);
            this.buttonSeeResults.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSeeResults.Name = "buttonSeeResults";
            this.buttonSeeResults.Size = new System.Drawing.Size(213, 60);
            this.buttonSeeResults.TabIndex = 14;
            this.buttonSeeResults.Text = "Розрахувати!";
            this.buttonSeeResults.UseVisualStyleBackColor = true;
            this.buttonSeeResults.Click += new System.EventHandler(this.buttonSeeResults_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Номер (індекс) максимального елемента масиву:";
            // 
            // textBoxIndexMaxArrElem
            // 
            this.textBoxIndexMaxArrElem.Enabled = false;
            this.textBoxIndexMaxArrElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIndexMaxArrElem.Location = new System.Drawing.Point(350, 264);
            this.textBoxIndexMaxArrElem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIndexMaxArrElem.Name = "textBoxIndexMaxArrElem";
            this.textBoxIndexMaxArrElem.Size = new System.Drawing.Size(263, 26);
            this.textBoxIndexMaxArrElem.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Максимальний за модулем елемент масиву:";
            // 
            // textBoxMaxModuleArrElem
            // 
            this.textBoxMaxModuleArrElem.Enabled = false;
            this.textBoxMaxModuleArrElem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMaxModuleArrElem.Location = new System.Drawing.Point(350, 311);
            this.textBoxMaxModuleArrElem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaxModuleArrElem.Name = "textBoxMaxModuleArrElem";
            this.textBoxMaxModuleArrElem.Size = new System.Drawing.Size(263, 26);
            this.textBoxMaxModuleArrElem.TabIndex = 18;
            // 
            // dataGridViewSortedArr
            // 
            this.dataGridViewSortedArr.AllowUserToAddRows = false;
            this.dataGridViewSortedArr.AllowUserToDeleteRows = false;
            this.dataGridViewSortedArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSortedArr.Location = new System.Drawing.Point(12, 486);
            this.dataGridViewSortedArr.Name = "dataGridViewSortedArr";
            this.dataGridViewSortedArr.Size = new System.Drawing.Size(424, 102);
            this.dataGridViewSortedArr.TabIndex = 19;
            // 
            // labelEnterArrSize
            // 
            this.labelEnterArrSize.AutoSize = true;
            this.labelEnterArrSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEnterArrSize.Location = new System.Drawing.Point(13, 23);
            this.labelEnterArrSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnterArrSize.Name = "labelEnterArrSize";
            this.labelEnterArrSize.Size = new System.Drawing.Size(241, 16);
            this.labelEnterArrSize.TabIndex = 20;
            this.labelEnterArrSize.Text = "Введіть кількість елементів масиву:";
            // 
            // textBoxArrSize
            // 
            this.textBoxArrSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArrSize.Location = new System.Drawing.Point(275, 18);
            this.textBoxArrSize.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxArrSize.Name = "textBoxArrSize";
            this.textBoxArrSize.Size = new System.Drawing.Size(296, 26);
            this.textBoxArrSize.TabIndex = 21;
            // 
            // dataGridViewArrayEntering
            // 
            this.dataGridViewArrayEntering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrayEntering.Location = new System.Drawing.Point(16, 56);
            this.dataGridViewArrayEntering.Name = "dataGridViewArrayEntering";
            this.dataGridViewArrayEntering.Size = new System.Drawing.Size(555, 87);
            this.dataGridViewArrayEntering.TabIndex = 22;
            // 
            // buttonEnterArrSize
            // 
            this.buttonEnterArrSize.Location = new System.Drawing.Point(635, 16);
            this.buttonEnterArrSize.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEnterArrSize.Name = "buttonEnterArrSize";
            this.buttonEnterArrSize.Size = new System.Drawing.Size(138, 33);
            this.buttonEnterArrSize.TabIndex = 23;
            this.buttonEnterArrSize.Text = "Ввести кількість";
            this.buttonEnterArrSize.UseVisualStyleBackColor = true;
            this.buttonEnterArrSize.Click += new System.EventHandler(this.buttonEnterArrSize_Click);
            // 
            // dataGridViewArrDeletedNegElem
            // 
            this.dataGridViewArrDeletedNegElem.AllowUserToAddRows = false;
            this.dataGridViewArrDeletedNegElem.AllowUserToDeleteRows = false;
            this.dataGridViewArrDeletedNegElem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArrDeletedNegElem.Location = new System.Drawing.Point(597, 486);
            this.dataGridViewArrDeletedNegElem.Name = "dataGridViewArrDeletedNegElem";
            this.dataGridViewArrDeletedNegElem.Size = new System.Drawing.Size(421, 102);
            this.dataGridViewArrDeletedNegElem.TabIndex = 24;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Author.Location = new System.Drawing.Point(877, 617);
            this.Author.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(141, 16);
            this.Author.TabIndex = 25;
            this.Author.Text = "By Olena Machushnyk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 642);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.dataGridViewArrDeletedNegElem);
            this.Controls.Add(this.buttonEnterArrSize);
            this.Controls.Add(this.dataGridViewArrayEntering);
            this.Controls.Add(this.textBoxArrSize);
            this.Controls.Add(this.labelEnterArrSize);
            this.Controls.Add(this.dataGridViewSortedArr);
            this.Controls.Add(this.textBoxMaxModuleArrElem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIndexMaxArrElem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSeeResults);
            this.Controls.Add(this.textBoxQuantityIntArrElems);
            this.Controls.Add(this.textBoxSumIndexesPositiveArrElems);
            this.Controls.Add(this.textBoxMaxArrElem);
            this.Controls.Add(this.textBoxSumNegArrElems);
            this.Controls.Add(this.labelDeletedNegArrElems);
            this.Controls.Add(this.labelSortedArrDecreasing);
            this.Controls.Add(this.labelQuantityIntArrElems);
            this.Controls.Add(this.labelSumIndexesPositiveArrElems);
            this.Controls.Add(this.labelMaxArrElem);
            this.Controls.Add(this.labelSumNegArrElems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "ISMDotNet3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSortedArr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrayEntering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArrDeletedNegElem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSumNegArrElems;
        private System.Windows.Forms.Label labelMaxArrElem;
        private System.Windows.Forms.Label labelSumIndexesPositiveArrElems;
        private System.Windows.Forms.Label labelQuantityIntArrElems;
        private System.Windows.Forms.Label labelSortedArrDecreasing;
        private System.Windows.Forms.Label labelDeletedNegArrElems;
        private System.Windows.Forms.TextBox textBoxSumNegArrElems;
        private System.Windows.Forms.TextBox textBoxMaxArrElem;
        private System.Windows.Forms.TextBox textBoxSumIndexesPositiveArrElems;
        private System.Windows.Forms.TextBox textBoxQuantityIntArrElems;
        private System.Windows.Forms.Button buttonSeeResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIndexMaxArrElem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaxModuleArrElem;
        private System.Windows.Forms.DataGridView dataGridViewSortedArr;
        private System.Windows.Forms.Label labelEnterArrSize;
        private System.Windows.Forms.TextBox textBoxArrSize;
        private System.Windows.Forms.DataGridView dataGridViewArrayEntering;
        private System.Windows.Forms.Button buttonEnterArrSize;
        private System.Windows.Forms.DataGridView dataGridViewArrDeletedNegElem;
        private System.Windows.Forms.Label Author;
    }
}

