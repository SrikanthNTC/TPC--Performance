﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPC.Context.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class PenworthyEntities : DbContext
    {
        public PenworthyEntities()
            : base("name=PenworthyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserType> AppUserTypes { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<CalTagInfo> CalTagInfoes { get; set; }
        public DbSet<CatalogColumnType> CatalogColumnTypes { get; set; }
        public DbSet<CatalogInformation> CatalogInformations { get; set; }
        public DbSet<CatalogProfileValidation> CatalogProfileValidations { get; set; }
        public DbSet<CatalogSoftwareVersionMapping> CatalogSoftwareVersionMappings { get; set; }
        public DbSet<CatalogSubject> CatalogSubjects { get; set; }
        public DbSet<CatalogSubjectItemIDMapping> CatalogSubjectItemIDMappings { get; set; }
        public DbSet<CatalogSubjectOptionProtector> CatalogSubjectOptionProtectors { get; set; }
        public DbSet<CatalogSubjectOptionProtectorValue> CatalogSubjectOptionProtectorValues { get; set; }
        public DbSet<CatalogSubjectOption> CatalogSubjectOptions { get; set; }
        public DbSet<CatalogSubjectoptionShelfReady> CatalogSubjectoptionShelfReadies { get; set; }
        public DbSet<CatalogSubjectOptionShelfReadyValue> CatalogSubjectOptionShelfReadyValues { get; set; }
        public DbSet<CatalogSubjectOptionValue> CatalogSubjectOptionValues { get; set; }
        public DbSet<CollectionsDisplayPage> CollectionsDisplayPages { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerCatalogInformation> CustomerCatalogInformations { get; set; }
        public DbSet<CustomerCatalogProtectorInformation> CustomerCatalogProtectorInformations { get; set; }
        public DbSet<CustomerCatalogShelfReadyInformation> CustomerCatalogShelfReadyInformations { get; set; }
        public DbSet<CustomerRep> CustomerReps { get; set; }
        public DbSet<CustomerRepAssignment> CustomerRepAssignments { get; set; }
        public DbSet<CustomerSeriesCharacter> CustomerSeriesCharacters { get; set; }
        public DbSet<CustomerShipToAddress> CustomerShipToAddresses { get; set; }
        public DbSet<CustomerTag> CustomerTags { get; set; }
        public DbSet<CustomerTitle> CustomerTitles { get; set; }
        public DbSet<DWSelectionStatu> DWSelectionStatus { get; set; }
        public DbSet<ELMAH_Error> ELMAH_Error { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<FAQCategory> FAQCategories { get; set; }
        public DbSet<FAQDetail> FAQDetails { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupPackage> GroupPackages { get; set; }
        public DbSet<GroupPackageItem> GroupPackageItems { get; set; }
        public DbSet<GroupStyle> GroupStyles { get; set; }
        public DbSet<InvoiceHistory> InvoiceHistories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemHistory> ItemHistories { get; set; }
        public DbSet<ItemTag> ItemTags { get; set; }
        public DbSet<MailHistory> MailHistories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<PackageSubPackage> PackageSubPackages { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<QuoteCallTag> QuoteCallTags { get; set; }
        public DbSet<QuoteDetail> QuoteDetails { get; set; }
        public DbSet<QuoteSubmitSaveInfo> QuoteSubmitSaveInfoes { get; set; }
        public DbSet<QuoteType> QuoteTypes { get; set; }
        public DbSet<RepUser> RepUsers { get; set; }
        public DbSet<SeriesAndCharacter> SeriesAndCharacters { get; set; }
        public DbSet<SourceType> SourceTypes { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagType> TagTypes { get; set; }
        public DbSet<TaxSchedule> TaxSchedules { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPreference> UserPreferences { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
        public DbSet<vDWCRMComm> vDWCRMComms { get; set; }
        public DbSet<vDWMailHistory> vDWMailHistories { get; set; }
        public DbSet<vDWstat> vDWstats { get; set; }
        public DbSet<vQuote> vQuotes { get; set; }
        public DbSet<vWebUser> vWebUsers { get; set; }
    
        [EdmFunction("PenworthyEntities", "FnGetCatalogPrice")]
        public virtual IQueryable<FnGetCatalogPrice_Result> FnGetCatalogPrice(Nullable<int> custautoID, Nullable<int> quantity)
        {
            var custautoIDParameter = custautoID.HasValue ?
                new ObjectParameter("custautoID", custautoID) :
                new ObjectParameter("custautoID", typeof(int));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FnGetCatalogPrice_Result>("[PenworthyEntities].[FnGetCatalogPrice](@custautoID, @quantity)", custautoIDParameter, quantityParameter);
        }
    
        public virtual ObjectResult<string> ELMAH_GetErrorsXml(string application, Nullable<int> pageIndex, Nullable<int> pageSize, ObjectParameter totalCount)
        {
            var applicationParameter = application != null ?
                new ObjectParameter("Application", application) :
                new ObjectParameter("Application", typeof(string));
    
            var pageIndexParameter = pageIndex.HasValue ?
                new ObjectParameter("PageIndex", pageIndex) :
                new ObjectParameter("PageIndex", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ELMAH_GetErrorsXml", applicationParameter, pageIndexParameter, pageSizeParameter, totalCount);
        }
    
        public virtual ObjectResult<string> ELMAH_GetErrorXml(string application, Nullable<System.Guid> errorId)
        {
            var applicationParameter = application != null ?
                new ObjectParameter("Application", application) :
                new ObjectParameter("Application", typeof(string));
    
            var errorIdParameter = errorId.HasValue ?
                new ObjectParameter("ErrorId", errorId) :
                new ObjectParameter("ErrorId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ELMAH_GetErrorXml", applicationParameter, errorIdParameter);
        }
    
        public virtual int ELMAH_LogError(Nullable<System.Guid> errorId, string application, string host, string type, string source, string message, string user, string allXml, Nullable<int> statusCode, Nullable<System.DateTime> timeUtc)
        {
            var errorIdParameter = errorId.HasValue ?
                new ObjectParameter("ErrorId", errorId) :
                new ObjectParameter("ErrorId", typeof(System.Guid));
    
            var applicationParameter = application != null ?
                new ObjectParameter("Application", application) :
                new ObjectParameter("Application", typeof(string));
    
            var hostParameter = host != null ?
                new ObjectParameter("Host", host) :
                new ObjectParameter("Host", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var sourceParameter = source != null ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("Message", message) :
                new ObjectParameter("Message", typeof(string));
    
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var allXmlParameter = allXml != null ?
                new ObjectParameter("AllXml", allXml) :
                new ObjectParameter("AllXml", typeof(string));
    
            var statusCodeParameter = statusCode.HasValue ?
                new ObjectParameter("StatusCode", statusCode) :
                new ObjectParameter("StatusCode", typeof(int));
    
            var timeUtcParameter = timeUtc.HasValue ?
                new ObjectParameter("TimeUtc", timeUtc) :
                new ObjectParameter("TimeUtc", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELMAH_LogError", errorIdParameter, applicationParameter, hostParameter, typeParameter, sourceParameter, messageParameter, userParameter, allXmlParameter, statusCodeParameter, timeUtcParameter);
        }
    
        public virtual int SP_CalculateQuoteTotalPrice(Nullable<int> trgQuoteID)
        {
            var trgQuoteIDParameter = trgQuoteID.HasValue ?
                new ObjectParameter("TrgQuoteID", trgQuoteID) :
                new ObjectParameter("TrgQuoteID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_CalculateQuoteTotalPrice", trgQuoteIDParameter);
        }
    
        public virtual int SP_DeleteDWOfflistItems()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DeleteDWOfflistItems");
        }
    
        public virtual int SP_DuplicateUsersList(string customerNo)
        {
            var customerNoParameter = customerNo != null ?
                new ObjectParameter("CustomerNo", customerNo) :
                new ObjectParameter("CustomerNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_DuplicateUsersList", customerNoParameter);
        }
    
        public virtual int SP_GetActiveQuoteVM(Nullable<int> userID)
        {
            var userIDParameter = userID.HasValue ?
                new ObjectParameter("userID", userID) :
                new ObjectParameter("userID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_GetActiveQuoteVM", userIDParameter);
        }
    
        public virtual int sp_GetCustomerDivNo(string customerNo, ObjectParameter divNo)
        {
            var customerNoParameter = customerNo != null ?
                new ObjectParameter("CustomerNo", customerNo) :
                new ObjectParameter("CustomerNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetCustomerDivNo", customerNoParameter, divNo);
        }
    
        public virtual int sp_GetInvoiceHisoryFileName(string invoiceNo, ObjectParameter fileName)
        {
            var invoiceNoParameter = invoiceNo != null ?
                new ObjectParameter("invoiceNo", invoiceNo) :
                new ObjectParameter("invoiceNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetInvoiceHisoryFileName", invoiceNoParameter, fileName);
        }
    
        public virtual int SP_getitemlistByQuoteID(Nullable<int> quoteid, Nullable<int> custAutoId)
        {
            var quoteidParameter = quoteid.HasValue ?
                new ObjectParameter("quoteid", quoteid) :
                new ObjectParameter("quoteid", typeof(int));
    
            var custAutoIdParameter = custAutoId.HasValue ?
                new ObjectParameter("custAutoId", custAutoId) :
                new ObjectParameter("custAutoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_getitemlistByQuoteID", quoteidParameter, custAutoIdParameter);
        }
    
        public virtual int SP_InsertAuthors(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertAuthors", databaseNameParameter);
        }
    
        public virtual int SP_InsertCharacter(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertCharacter", databaseNameParameter);
        }
    
        public virtual int SP_InsertProspectiveCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertProspectiveCustomers");
        }
    
        public virtual int SP_InsertPublisher(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertPublisher", databaseNameParameter);
        }
    
        public virtual int SP_InsertSeconDaryCharacter(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertSeconDaryCharacter", databaseNameParameter);
        }
    
        public virtual int SP_InsertSeries(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertSeries", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateCustomerChildShipTOAddressBYCustAutoID(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateCustomerChildShipTOAddressBYCustAutoID", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateCustomerParentChildAddressBYCustAutoID(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateCustomerParentChildAddressBYCustAutoID", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateCustomerRelated(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateCustomerRelated", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateCustomerUsersData(string firstName, string lastName, string emailAddress, string compCustomerNo, string compDivisionNo, string salesPersonNo, Nullable<int> personID, string p_FirstName, string p_LastName, string p_EmailAddress)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailAddressParameter = emailAddress != null ?
                new ObjectParameter("EmailAddress", emailAddress) :
                new ObjectParameter("EmailAddress", typeof(string));
    
            var compCustomerNoParameter = compCustomerNo != null ?
                new ObjectParameter("CompCustomerNo", compCustomerNo) :
                new ObjectParameter("CompCustomerNo", typeof(string));
    
            var compDivisionNoParameter = compDivisionNo != null ?
                new ObjectParameter("CompDivisionNo", compDivisionNo) :
                new ObjectParameter("CompDivisionNo", typeof(string));
    
            var salesPersonNoParameter = salesPersonNo != null ?
                new ObjectParameter("salesPersonNo", salesPersonNo) :
                new ObjectParameter("salesPersonNo", typeof(string));
    
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("PersonID", personID) :
                new ObjectParameter("PersonID", typeof(int));
    
            var p_FirstNameParameter = p_FirstName != null ?
                new ObjectParameter("P_FirstName", p_FirstName) :
                new ObjectParameter("P_FirstName", typeof(string));
    
            var p_LastNameParameter = p_LastName != null ?
                new ObjectParameter("P_LastName", p_LastName) :
                new ObjectParameter("P_LastName", typeof(string));
    
            var p_EmailAddressParameter = p_EmailAddress != null ?
                new ObjectParameter("P_EmailAddress", p_EmailAddress) :
                new ObjectParameter("P_EmailAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateCustomerUsersData", firstNameParameter, lastNameParameter, emailAddressParameter, compCustomerNoParameter, compDivisionNoParameter, salesPersonNoParameter, personIDParameter, p_FirstNameParameter, p_LastNameParameter, p_EmailAddressParameter);
        }
    
        public virtual int SP_InsertUpdateInvoiceHistory(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateInvoiceHistory", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateInvoiceHistoryDetail()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateInvoiceHistoryDetail");
        }
    
        public virtual int SP_InsertUpdatePenworthtyMasters(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdatePenworthtyMasters", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdatePrimaryUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdatePrimaryUser");
        }
    
        public virtual int SP_InsertUpdateQuote(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateQuote", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateRepUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateRepUsers");
        }
    
        public virtual int SP_InsertUpdateRepUsersData(string firstName, string lastName, string emailAddress, string salesPersonNo, string salesARDivNo, string addressLine1, string city, string state, string zipcode, Nullable<bool> isActive, string phoneNo, string phoneDirectNo, Nullable<int> roleID, string p_FirstName, string p_LastName, string p_EmailAddress)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailAddressParameter = emailAddress != null ?
                new ObjectParameter("EmailAddress", emailAddress) :
                new ObjectParameter("EmailAddress", typeof(string));
    
            var salesPersonNoParameter = salesPersonNo != null ?
                new ObjectParameter("SalesPersonNo", salesPersonNo) :
                new ObjectParameter("SalesPersonNo", typeof(string));
    
            var salesARDivNoParameter = salesARDivNo != null ?
                new ObjectParameter("SalesARDivNo", salesARDivNo) :
                new ObjectParameter("SalesARDivNo", typeof(string));
    
            var addressLine1Parameter = addressLine1 != null ?
                new ObjectParameter("AddressLine1", addressLine1) :
                new ObjectParameter("AddressLine1", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipcodeParameter = zipcode != null ?
                new ObjectParameter("Zipcode", zipcode) :
                new ObjectParameter("Zipcode", typeof(string));
    
            var isActiveParameter = isActive.HasValue ?
                new ObjectParameter("IsActive", isActive) :
                new ObjectParameter("IsActive", typeof(bool));
    
            var phoneNoParameter = phoneNo != null ?
                new ObjectParameter("PhoneNo", phoneNo) :
                new ObjectParameter("PhoneNo", typeof(string));
    
            var phoneDirectNoParameter = phoneDirectNo != null ?
                new ObjectParameter("PhoneDirectNo", phoneDirectNo) :
                new ObjectParameter("PhoneDirectNo", typeof(string));
    
            var roleIDParameter = roleID.HasValue ?
                new ObjectParameter("RoleID", roleID) :
                new ObjectParameter("RoleID", typeof(int));
    
            var p_FirstNameParameter = p_FirstName != null ?
                new ObjectParameter("P_FirstName", p_FirstName) :
                new ObjectParameter("P_FirstName", typeof(string));
    
            var p_LastNameParameter = p_LastName != null ?
                new ObjectParameter("P_LastName", p_LastName) :
                new ObjectParameter("P_LastName", typeof(string));
    
            var p_EmailAddressParameter = p_EmailAddress != null ?
                new ObjectParameter("P_EmailAddress", p_EmailAddress) :
                new ObjectParameter("P_EmailAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateRepUsersData", firstNameParameter, lastNameParameter, emailAddressParameter, salesPersonNoParameter, salesARDivNoParameter, addressLine1Parameter, cityParameter, stateParameter, zipcodeParameter, isActiveParameter, phoneNoParameter, phoneDirectNoParameter, roleIDParameter, p_FirstNameParameter, p_LastNameParameter, p_EmailAddressParameter);
        }
    
        public virtual int SP_InsertUpdateUserCustomerParentAndChild(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateUserCustomerParentAndChild", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateUserCustomersRelated(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateUserCustomersRelated", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateUserRepRelated(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateUserRepRelated", databaseNameParameter);
        }
    
        public virtual int SP_InsertUpdateUsers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_InsertUpdateUsers");
        }
    
        public virtual int sp_InserUpdateUserByPersonId(Nullable<int> personId, Nullable<int> repId, string customerNo, Nullable<int> ardivisionNO)
        {
            var personIdParameter = personId.HasValue ?
                new ObjectParameter("personId", personId) :
                new ObjectParameter("personId", typeof(int));
    
            var repIdParameter = repId.HasValue ?
                new ObjectParameter("repId", repId) :
                new ObjectParameter("repId", typeof(int));
    
            var customerNoParameter = customerNo != null ?
                new ObjectParameter("customerNo", customerNo) :
                new ObjectParameter("customerNo", typeof(string));
    
            var ardivisionNOParameter = ardivisionNO.HasValue ?
                new ObjectParameter("ardivisionNO", ardivisionNO) :
                new ObjectParameter("ardivisionNO", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InserUpdateUserByPersonId", personIdParameter, repIdParameter, customerNoParameter, ardivisionNOParameter);
        }
    
        public virtual int SP_MergePerson(string customerNo, string email, Nullable<int> targetPersonID)
        {
            var customerNoParameter = customerNo != null ?
                new ObjectParameter("CustomerNo", customerNo) :
                new ObjectParameter("CustomerNo", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var targetPersonIDParameter = targetPersonID.HasValue ?
                new ObjectParameter("TargetPersonID", targetPersonID) :
                new ObjectParameter("TargetPersonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_MergePerson", customerNoParameter, emailParameter, targetPersonIDParameter);
        }
    
        public virtual int SP_RemoveItemFromQuotesandItembyItemID(string itemID)
        {
            var itemIDParameter = itemID != null ?
                new ObjectParameter("ItemID", itemID) :
                new ObjectParameter("ItemID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_RemoveItemFromQuotesandItembyItemID", itemIDParameter);
        }
    
        public virtual int SP_UpdateAuthors(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateAuthors", databaseNameParameter);
        }
    
        public virtual int SP_UpdateCharacter(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateCharacter", databaseNameParameter);
        }
    
        public virtual int SP_UpdateCustomerAgingcategories(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateCustomerAgingcategories", databaseNameParameter);
        }
    
        public virtual int SP_UpdateCustomerPORequirement(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateCustomerPORequirement", databaseNameParameter);
        }
    
        public virtual int SP_UpdateCustomerPORequirementByCustAutoId(Nullable<int> custumerAutoId)
        {
            var custumerAutoIdParameter = custumerAutoId.HasValue ?
                new ObjectParameter("CustumerAutoId", custumerAutoId) :
                new ObjectParameter("CustumerAutoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateCustomerPORequirementByCustAutoId", custumerAutoIdParameter);
        }
    
        public virtual int SP_UpdateItemMaster(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateItemMaster", databaseNameParameter);
        }
    
        public virtual int SP_UpdatePublisher(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdatePublisher", databaseNameParameter);
        }
    
        public virtual int SP_UpdateQuoteStatusByInvoiceHistory(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateQuoteStatusByInvoiceHistory", databaseNameParameter);
        }
    
        public virtual int SP_UpdateRepUserAuditFlag(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateRepUserAuditFlag", databaseNameParameter);
        }
    
        public virtual int SP_UpdateSecondaryCharacter(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateSecondaryCharacter", databaseNameParameter);
        }
    
        public virtual int SP_UpdateSeries(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateSeries", databaseNameParameter);
        }
    
        public virtual int SP_UpdateSeriesCharacter(string databaseName)
        {
            var databaseNameParameter = databaseName != null ?
                new ObjectParameter("DatabaseName", databaseName) :
                new ObjectParameter("DatabaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_UpdateSeriesCharacter", databaseNameParameter);
        }
    
        public virtual ObjectResult<spgetCustomers_Result> spgetCustomers()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spgetCustomers_Result>("spgetCustomers");
        }
    }
}
