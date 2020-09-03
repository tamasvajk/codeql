import csharp
import semmle.code.csharp.dataflow.SignAnalysis
import semmle.code.csharp.dataflow.SsaReadPosition
import semmle.code.csharp.dataflow.SSA
import semmle.code.csharp.dataflow.RangeUtils

private predicate variableAcc(
  VariableAccess va, Ssa::Definition v, Expr guard, Expr bound, string boundSign, string gSign
) {
  va.fromSource() and
  va.getEnclosingCallable().getDeclaringType().getName() = "SignAnalysis" and
  va.getLocation().getStartLine() = 85 and
  v.getARead() = va and
  exists(SsaReadPosition pos, Sign s, Sign gs |
    pos.hasReadOfVar(v) and
    guardControlsSsaRead(guard, pos, true) and
    upperBound(bound, v, pos, false) and
    s = exprSign(bound) and
    boundSign = s.toString() and
    negBoundOk(bound, v, pos) and
    gs = ssaSign(v, pos) and
    gSign = gs.toString() and
    negative(va)
  )
}

string getASignString(Expr e) {
  positive(e) and
  result = "positive"
  or
  negative(e) and
  result = "negative"
  or
  strictlyPositive(e) and
  result = "strictlyPositive"
  or
  strictlyNegative(e) and
  result = "strictlyNegative"
}

from Expr e
select e, strictconcat(string s | s = getASignString(e) | s, " ")
