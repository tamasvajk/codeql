// generated by codegen, do not edit
import codeql.rust.elements
import TestUtils

from BinaryExpr x, int getNumberOfAttrs, string hasLhs, string hasOperatorName, string hasRhs
where
  toBeTested(x) and
  not x.isUnknown() and
  getNumberOfAttrs = x.getNumberOfAttrs() and
  (if x.hasLhs() then hasLhs = "yes" else hasLhs = "no") and
  (if x.hasOperatorName() then hasOperatorName = "yes" else hasOperatorName = "no") and
  if x.hasRhs() then hasRhs = "yes" else hasRhs = "no"
select x, "getNumberOfAttrs:", getNumberOfAttrs, "hasLhs:", hasLhs, "hasOperatorName:",
  hasOperatorName, "hasRhs:", hasRhs
