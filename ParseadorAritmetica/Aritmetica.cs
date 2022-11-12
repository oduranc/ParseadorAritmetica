using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseadorAritmetica
{
    internal class Aritmetica : aritmeticaBaseVisitor<int>
    {
        public override int VisitAritmetica([NotNull] aritmeticaParser.AritmeticaContext context)
        {
            Console.WriteLine($"Visitando Aritmética: {context.GetText()}");
            return base.VisitAritmetica(context);
        }

        public override int VisitExpresion([NotNull] aritmeticaParser.ExpresionContext context)
        {
            Console.WriteLine($"Visitando Expresión: {context.GetText()}");
            return base.VisitExpresion(context);
        }

        public override int VisitFactor([NotNull] aritmeticaParser.FactorContext context)
        {
            Console.WriteLine($"Visitando Factor: {context.GetText()}");
            return base.VisitFactor(context);
        }

        public override int VisitTermino([NotNull] aritmeticaParser.TerminoContext context)
        {
            Console.WriteLine($"Visitando Término: {context.GetText()}");
            return base.VisitTermino(context);
        }
    }
}
