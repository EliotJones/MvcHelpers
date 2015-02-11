namespace EliotJones.MvcHelpers.ViewModels.RadioButtons
{
    public class RadioButtonPair<TKey, TValue>
    {
        public virtual TKey Key { get; set; }

        public virtual TValue Value { get; set; }
    }
}