// generated by codegen/codegen.py, do not edit
import codeql.swift.elements
import TestUtils

from ImplicitConversionExpr x, string hasType, Expr getSubExpr
where
  toBeTested(x) and
  not x.isUnknown() and
  (if x.hasType() then hasType = "yes" else hasType = "no") and
  getSubExpr = x.getSubExpr()
select x, x.getPrimaryQlClasses(), "hasType:", hasType, "getSubExpr:", getSubExpr
