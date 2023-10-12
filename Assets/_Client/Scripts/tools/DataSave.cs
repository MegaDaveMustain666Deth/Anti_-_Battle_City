namespace DataSave
{
    [System.Serializable]

    public class Save
    {
        private int _maxCompanyUnlocked;
        private int _maxLevelInCompanies;
        public int GetCompany() => _maxCompanyUnlocked;
        public int GetLevel() => _maxLevelInCompanies;
        public int SetCompany(int company)
        {
            _maxCompanyUnlocked += company;
            return _maxCompanyUnlocked;
        }
        public int SetLevel(int level)
        {
            _maxLevelInCompanies += level;
            return _maxLevelInCompanies;
        }
    }
}
