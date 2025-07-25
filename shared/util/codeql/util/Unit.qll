/** Provides the `Unit` class. */
overlay[local?]
module;

/** The unit type. */
private newtype TUnit = TMkUnit()

/** The trivial type with a single element. */
final class Unit extends TUnit {
  /** Gets a textual representation of this element. */
  string toString() { result = "unit" }
}
