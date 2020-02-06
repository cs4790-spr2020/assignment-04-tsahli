namespace BlabberApp.Domain
{
    public interface IDataStore
    {
        bool Create(IDatum datum);
        IDatum Read(ISpecimen specimen);
        bool Update(IDatum datum);
        bool Delete(ISpecimen specimen);
    }
}