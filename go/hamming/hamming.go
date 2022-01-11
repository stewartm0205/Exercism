package hamming

import "errors"

func Distance(a, b string) (int, error) {
	

	if len(a) != len(b) {	
		return 0, errors.New("bad arguments")
	}
	var dist int;
	for i := range a {
		if a[i] != b[i] {
			dist++;
		}
	}
	return dist, nil

}
