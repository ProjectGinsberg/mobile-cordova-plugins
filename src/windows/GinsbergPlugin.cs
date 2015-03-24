namespace GinsbergPlugin
{
    public sealed class ManagedCalls
    {
        public static string GetAnswer() 
        { 
            return "The answer is 42."; 
        }

        public int SampleProperty { get; set; }
    }
}