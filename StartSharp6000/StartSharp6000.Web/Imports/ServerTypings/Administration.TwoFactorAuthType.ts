namespace StartSharp6000.Administration {
    export enum TwoFactorAuthType {
        Email = 1,
        SMS = 2
    }
    Serenity.Decorators.registerEnumType(TwoFactorAuthType, 'StartSharp6000.Administration.TwoFactorAuthType');
}
