

fn main() {
let a = [1,2,3];
let b = [4,5,6];
if a.len() == b.len() {
	for t in a.iter().zip(b.iter()){
		println!("{:?}",t);
	}
}
}
