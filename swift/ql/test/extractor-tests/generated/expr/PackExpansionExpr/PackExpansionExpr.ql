// generated by codegen/codegen.py, do not edit
import codeql.swift.elements
import TestUtils

query predicate instances(PackExpansionExpr x, string getPatternExpr__label, Expr getPatternExpr) {
  toBeTested(x) and
  not x.isUnknown() and
  getPatternExpr__label = "getPatternExpr:" and
  getPatternExpr = x.getPatternExpr()
}

query predicate getType(PackExpansionExpr x, Type getType) {
  toBeTested(x) and not x.isUnknown() and getType = x.getType()
}
