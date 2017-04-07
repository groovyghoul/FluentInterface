namespace FluentInterface
{
    public interface IWordAdded
    {
        IWordAdded AddWord(string word);
        IFinalWordAdded FinalWord(string word);
    }
}
