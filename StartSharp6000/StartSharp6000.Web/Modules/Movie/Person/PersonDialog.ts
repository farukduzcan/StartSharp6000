
namespace StartSharp6000.Movie {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    export class PersonDialog extends Serenity.EntityDialog<PersonRow, any> {
        protected getFormKey() { return PersonForm.formKey; }
        protected getIdProperty() { return PersonRow.idProperty; }
        protected getLocalTextPrefix() { return PersonRow.localTextPrefix; }
        protected getNameProperty() { return PersonRow.nameProperty; }
        protected getService() { return PersonService.baseUrl; }
        protected getDeletePermission() { return PersonRow.deletePermission; }
        protected getInsertPermission() { return PersonRow.insertPermission; }
        protected getUpdatePermission() { return PersonRow.updatePermission; }
        protected afterLoadEntity() {
            super.afterLoadEntity();

            this.form.MoviesGrid.personID = this.entityId;
        }

        protected form = new PersonForm(this.idPrefix);

    }
}