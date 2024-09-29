namespace s11215103.Models
{
    public class People
    {
        public string 帳號 { get; set; }
        public string 性別 { get; set; }
        public int 身高 { get; set; }
        public float 體重 { get; set; }
        public float 標準體重 { get; set; }
        public float BMI { get; set; }

        // 方法成員
        public void 計算標準體重()
        {
            if (性別 == "男")
                標準體重 = (身高 - 80) * 0.7f;
            else
                標準體重 = (身高 - 70) * 0.6f;
        }

        public void 計算BMI()
        {
            BMI = 體重 / ((身高 / 100f) * (身高 / 100f)); // 注意身高轉換成米
        }

    }
}
