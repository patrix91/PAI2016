namespace Ftims.Pai.Service.Entity
{
    public interface IEntity<T> where T:class
    {
        T ToDto();
    }
}
