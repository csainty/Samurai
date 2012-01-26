namespace IdeaStrike.Tests
{
    public abstract class SpecificationFor<T>
    {
        public T Subject;

        public abstract T Given();
        public abstract void When();

        public SpecificationFor()
        {
            Subject = Given();
            When();
        }
    }
}

