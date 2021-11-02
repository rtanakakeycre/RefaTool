
namespace RefaTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmniEditUc1 = new CmniLib.CmniEditUc();
            this.cmniCtrlUc1 = new CmniLib.CmniCtrlUc(this.components);
            this.SuspendLayout();
            // 
            // cmniEditUc1
            // 
            this.cmniEditUc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmniEditUc1.Location = new System.Drawing.Point(1, 428);
            this.cmniEditUc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmniEditUc1.MaximumSize = new System.Drawing.Size(275, 21);
            this.cmniEditUc1.MinimumSize = new System.Drawing.Size(144, 21);
            this.cmniEditUc1.Name = "cmniEditUc1";
            this.cmniEditUc1.Size = new System.Drawing.Size(189, 21);
            this.cmniEditUc1.TabIndex = 0;
            this.cmniEditUc1.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmniEditUc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CmniLib.CmniCtrlUc cmniCtrlUc1;
        private CmniLib.CmniEditUc cmniEditUc1;
    }
}

