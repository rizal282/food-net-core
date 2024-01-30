namespace foodapi.Constans;

public static class ConstansTable
{
    // for schemas
    public const string SCHEMA_NAME = "";

    // for tables
    public const string FOODS_TABLE_NAME = "foods";
    public const string CUSTOMERS_TABLE_NAME = "customers";
    public const string ORDERS_TABLE_NAME = "orders";
    public const string CATEGORY_FOODS_TABLE_NAME = "category_foods";

    // for columns name
    // primary column name key
    public const string ID = "id";

    // all columns name for table foods
    public const string FOOD_NAME = "name";
    public const string FOOD_PRICE = "price";
    public const string FOOD_CATEGORY_ID = "category_id";

    // all columns name for table customers
    public const string CUSTOMER_NAME = "name";
    public const string CUSTOMER_PHONE_NUMBER = "phone_number";
    public const string CUSTOMER_EMAIL = "email";
    public const string CUSTOMER_ADDRESS = "address";

    // all columns name for table orders
    public const string ORDER_CUSTOMER_ID = "customer_id";
    public const string ORDER_FOOD_ID = "food_id";
    public const string ORDER_TOTAL_ITEM = "total_item";
    public const string ORDER_SUB_TOTAL = "sub_total";
    public const string ORDER_DATE_ORDER = "date_order";

    // all columns name for table category foods
    public const string CATEGORY_FOOD_NAME = "name";
    public const string CATEGORY_FOOD_DESCRIPTION = "description";
}