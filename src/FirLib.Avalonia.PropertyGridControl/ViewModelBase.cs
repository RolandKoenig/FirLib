namespace FirLib.Avalonia.PropertyGridControl;

public class ViewModelBase : PropertyChangedBase
{
    ///// <summary>
    ///// Gets the view service of the given type.
    ///// </summary>
    //protected T GetViewService<T>()
    //    where T : class
    //{
    //    var eventArgs = new ViewServiceRequestEventArgs(typeof(T));
    //    this.ViewServiceRequest?.Invoke(this, eventArgs);
    //
    //    if (!(eventArgs.ViewService is T result))
    //    {
    //        throw new ApplicationException($"Unable to get view service of type {typeof(T).FullName}!");
    //    }
    //    return result;
    //}
}