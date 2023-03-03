namespace StartSharp6000.Administration {

    @Serenity.Decorators.registerClass()
    export class UserGrid extends Serenity.EntityGrid<UserRow, any> {
        protected getColumnsKey() { return Administration.UserColumns.columnsKey; }
        protected getDialogType() { return UserDialog; }
        protected getIdProperty() { return UserRow.idProperty; }
        protected getIsActiveProperty() { return UserRow.isActiveProperty; }
        protected getLocalTextPrefix() { return UserRow.localTextPrefix; }
        protected getService() { return UserService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getDefaultSortBy() {
            return [UserRow.Fields.Username];
        }

        protected getColumns() {
            var columns = super.getColumns();

            var impersonate = Q.tryFirst(columns, x => x.field == "ImpersonationToken");
            if (impersonate != null) {
                impersonate.format = ctx => {
                    if (!ctx.value)
                        return "";

                    return `<a target="_blank" href="${Q.resolveUrl('~/Account/ImpersonateAs?token=')}${ctx.value}">`
                        + `<i class="fa fa-user-secret text-blue"></i></a>`;
                };
            }

            var roles = Q.tryFirst(columns, x => x.field == UserRow.Fields.Roles);
            if (roles) {
                roles.format = ctx => {
                    var roleList = (ctx.value || []).map(x => (RoleRow.getLookup().itemById[x] || {}).RoleName || "");
                    roleList.sort();
                    return roleList.join(", ");
                };
            }

            return columns;
        }
    }
}