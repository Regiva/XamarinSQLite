namespace XamarinSQLite
{
    public enum MenuItemType
    {
        BtcFromSqlite,
        BtcFromServer,
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
