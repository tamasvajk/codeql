/**
 * This module provides a hand-modifiable wrapper around the generated class `CallExprBase`.
 *
 * INTERNAL: Do not use.
 */

private import codeql.rust.elements.internal.generated.CallExprBase
private import codeql.rust.elements.Resolvable

/**
 * INTERNAL: This module contains the customizable definition of `CallExprBase` and should not
 * be referenced directly.
 */
module Impl {
  private import rust

  pragma[nomagic]
  Resolvable getCallResolvable(CallExprBase call) {
    result = call.(MethodCallExpr)
    or
    result = call.(CallExpr).getFunction().(PathExpr)
  }

  // the following QLdoc is generated: if you need to edit it, do it in the schema file
  /**
   * A function or method call expression. See `CallExpr` and `MethodCallExpr` for further details.
   */
  class CallExprBase extends Generated::CallExprBase {
    /** Gets the static target of this call, if any. */
    Callable getStaticTarget() { none() } // overridden by subclasses, but cannot be made abstract

    override Expr getArg(int index) { result = this.getArgList().getArg(index) }
  }
}
