private import codeql.swift.generated.expr.StringLiteralExpr

module Impl {
  /**
   * A string literal. For example `"abc"` in:
   * ```
   * let x = "abc"
   * ```
   */
  class StringLiteralExpr extends Generated::StringLiteralExpr {
    override string toStringImpl() { result = this.getValue() }

    override string getValueString() { result = this.getValue() }
  }
}
