
// Package twofer does a one for me , two for you
package twofer

// ShareWith returns the "one for" phrase
func ShareWith(name string) string {
	if (name == "") {
		return "One for you, one for me."
	} else {
		return "One for " + name + ", one for me."
	}
}
