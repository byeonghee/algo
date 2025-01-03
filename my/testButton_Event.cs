public class testButton_Event
{

    class Button
    {
        public string Text;

        public event EventHandler Click;
        public void MouseButtonClick()
        {
            if (this.Click != null)
            {
                Click(this, EventArgs.Empty);
            }
        }
    }
    public void Solution()
    {
        Button button = new Button();

        button.Click += new EventHandler(btn_Click);
        button.Text = "123";
    }
    void btn_Click(object sender, EventArgs e)
    {
        Console.WriteLine("btn_click");
    }
}