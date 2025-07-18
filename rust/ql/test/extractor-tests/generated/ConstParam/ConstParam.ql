// generated by codegen, do not edit
import codeql.rust.elements
import TestUtils

query predicate instances(ConstParam x, string isConst__label, string isConst) {
  toBeTested(x) and
  not x.isUnknown() and
  isConst__label = "isConst:" and
  if x.isConst() then isConst = "yes" else isConst = "no"
}

query predicate getAttr(ConstParam x, int index, Attr getAttr) {
  toBeTested(x) and not x.isUnknown() and getAttr = x.getAttr(index)
}

query predicate getDefaultVal(ConstParam x, ConstArg getDefaultVal) {
  toBeTested(x) and not x.isUnknown() and getDefaultVal = x.getDefaultVal()
}

query predicate getName(ConstParam x, Name getName) {
  toBeTested(x) and not x.isUnknown() and getName = x.getName()
}

query predicate getTypeRepr(ConstParam x, TypeRepr getTypeRepr) {
  toBeTested(x) and not x.isUnknown() and getTypeRepr = x.getTypeRepr()
}
