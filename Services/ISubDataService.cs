namespace TechExam.Services
{

    public abstract class ICollectionOfAbstract2
    {
        public int amount;

        public abstract void CalculateValue();

        public void SetTheValue(int value)
        {
            amount = value;
        }

        public void DisplayResult()
        {
            Console.WriteLine($"THIS IS THE RESULT {amount}");
        }
    }

    public class DerivedClassFromAbstract2 : ICollectionOfAbstract2
    {
        int _value { get; set; }

        public DerivedClassFromAbstract2(int value)
        {
            _value = value;
        }

        public override void CalculateValue()
        {
            amount = amount + _value;
        }
    }

    public class ISubDataService : SubDataInterface
    {

        public async Task<object> TestingOfInterface(int value)
        {
            var derivedClass = new DerivedClassFromAbstract2(23);
            derivedClass.SetTheValue(2);
            derivedClass.CalculateValue();
            derivedClass.DisplayResult();
            Console.WriteLine("TEST IF THIS IS CALLED, SUB DATA SERVICE");
            return value;
        }
    }
}
