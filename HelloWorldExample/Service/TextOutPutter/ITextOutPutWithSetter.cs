namespace MyFirstProject.Service.TextOutPutter
{
    public interface ITextOutPutWithSetter : ITextOutPut

    {
        void SetTextFromNumber(int number);
    }
}
