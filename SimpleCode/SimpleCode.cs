namespace SimpleCode
{
    public class SimpleCode
    {
        public string Value { get; set; }  

        public SimpleCode Merge(SimpleCode parameter)
        {
            var mergedObject = new SimpleCode();
            if (parameter.Value != null || this.Value != null)
            {
                mergedObject.Value = parameter.Value ?? this.Value;
            }
            return mergedObject;
        }
    }
}
