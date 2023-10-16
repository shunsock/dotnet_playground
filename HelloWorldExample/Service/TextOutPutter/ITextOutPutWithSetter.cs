namespace MyFirstProject.Service.TextOutPutter
{
    public interface ITextOutPutWithSetter : ITextOutPut

    {
        void SetTextFromNumbers(int number);
    }
}
