namespace BlabberApp.Domain
{
    public interface IDataStore
    {
        bool Create(IDatum datum);
        IDatum Read(int index);
        bool Update(IDatum datum);
        bool Delete(ISpecimen specimen);
    }
}