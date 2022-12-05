namespace Presenters.Interfaces
{
    public interface IPresenter<T>
    {
        public T? Content { get; set; }
    }
}
