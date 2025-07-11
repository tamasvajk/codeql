// generated by codegen/codegen.py, do not edit
import codeql.swift.elements
import TestUtils

query predicate instances(
  DotSyntaxCallExpr x, string getFunction__label, Expr getFunction, string getBase__label,
  Expr getBase
) {
  toBeTested(x) and
  not x.isUnknown() and
  getFunction__label = "getFunction:" and
  getFunction = x.getFunction() and
  getBase__label = "getBase:" and
  getBase = x.getBase()
}

query predicate getType(DotSyntaxCallExpr x, Type getType) {
  toBeTested(x) and not x.isUnknown() and getType = x.getType()
}

query predicate getArgument(DotSyntaxCallExpr x, int index, Argument getArgument) {
  toBeTested(x) and not x.isUnknown() and getArgument = x.getArgument(index)
}
