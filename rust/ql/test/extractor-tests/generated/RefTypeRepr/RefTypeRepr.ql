// generated by codegen, do not edit
import codeql.rust.elements
import TestUtils

query predicate instances(RefTypeRepr x, string isMut__label, string isMut) {
  toBeTested(x) and
  not x.isUnknown() and
  isMut__label = "isMut:" and
  if x.isMut() then isMut = "yes" else isMut = "no"
}

query predicate getLifetime(RefTypeRepr x, Lifetime getLifetime) {
  toBeTested(x) and not x.isUnknown() and getLifetime = x.getLifetime()
}

query predicate getTypeRepr(RefTypeRepr x, TypeRepr getTypeRepr) {
  toBeTested(x) and not x.isUnknown() and getTypeRepr = x.getTypeRepr()
}
