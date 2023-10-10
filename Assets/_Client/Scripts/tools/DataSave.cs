namespace DataSave
{
    [System.Serializable]

    public class Save
    {
        private int _maxCompanyUnlocked;
        private int _maxLevelInCompanies;
        public int GetCompany() => _maxCompanyUnlocked;
        public int GetLevel() => _maxLevelInCompanies;
    }
}
