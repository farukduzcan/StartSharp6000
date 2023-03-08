
namespace StartSharp6000.Movie {
    @Serenity.Decorators.registerFormatter("StartSharp6000.Movie.GenreListFormatter")
    export class GenreListFormatter implements Slick.Formatter {
        format(ctx: Slick.FormatterContext) {
            let idList = ctx.value as number[];
            if (!idList || !idList.length)
                return "";

            let byId = GenreRow.getLookup().itemById;
            console.log(GenreRow.getLookup());

            return idList.map(x => {
                let g = byId[x];
                if (!g)
                    return x.toString();

                return Q.htmlEncode(g.Name);
            }).join(", ");
        }
    }
}

