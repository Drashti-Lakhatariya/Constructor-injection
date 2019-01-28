namespace DAL
{
    public interface IDataAccess
    {
        void InsertData(string _name, string _gender, string _dob);
        void UpdateData(string _name, string _gender, string _dob);
        void DeleteData(string _name);
        object SelectData();
    }
}