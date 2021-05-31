lgtm,codescanning
* Members extracted from `TupleTypes` have been fixed to be assigned to the underlying ``struct ValueTuple`N``.
* Interface members can be `virtual` or `abstract` depending on if the default implementation is defined or not.
* The `Modifiable::isUnsafe` predicate has been fixed to handle symbols that are not extracted from source code.
* The `isEffectivelyPrivate`, `isEffectivelyInternal` and `isEffectivelyPublic` predicates on `Modifiable` have been reworked to handle `private protected` and `internal protected` visibilities and explicitly implemented interfaces.
* Various API stubbing improvements have been added.
