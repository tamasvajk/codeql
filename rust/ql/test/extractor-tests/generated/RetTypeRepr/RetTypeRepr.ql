// generated by codegen, do not edit
import codeql.rust.elements
import TestUtils

query predicate instances(RetTypeRepr x) { toBeTested(x) and not x.isUnknown() }

query predicate getTypeRepr(RetTypeRepr x, TypeRepr getTypeRepr) {
  toBeTested(x) and not x.isUnknown() and getTypeRepr = x.getTypeRepr()
}
