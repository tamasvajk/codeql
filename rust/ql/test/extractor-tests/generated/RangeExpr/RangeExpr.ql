// generated by codegen, do not edit
import codeql.rust.elements
import TestUtils

query predicate instances(RangeExpr x) { toBeTested(x) and not x.isUnknown() }

query predicate getAttr(RangeExpr x, int index, Attr getAttr) {
  toBeTested(x) and not x.isUnknown() and getAttr = x.getAttr(index)
}

query predicate getEnd(RangeExpr x, Expr getEnd) {
  toBeTested(x) and not x.isUnknown() and getEnd = x.getEnd()
}

query predicate getOperatorName(RangeExpr x, string getOperatorName) {
  toBeTested(x) and not x.isUnknown() and getOperatorName = x.getOperatorName()
}

query predicate getStart(RangeExpr x, Expr getStart) {
  toBeTested(x) and not x.isUnknown() and getStart = x.getStart()
}
