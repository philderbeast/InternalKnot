(*
In F#, the access control specifiers public, internal, and private can be applied to modules, types, methods, value definitions, functions, properties, and explicit fields.
public  indicates that the entity can be accessed by all callers.
internal  indicates that the entity can be accessed only from the same assembly.
private  indicates that the entity can be accessed only from the enclosing type or module.// Use internal for the module access and module members cannot be accessed from the same assembly.
SOURCE: http://msdn.microsoft.com/en-us/library/dd233188.aspx
*)

module internal Internal
// Replace the above with the following and this library compiles. That goes against what the docs say about internal, that "internal  indicates that the entity can be accessed only from the same assembly".
//module Internal

let f a = a + 1