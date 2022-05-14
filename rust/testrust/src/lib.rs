//use std::convert::TryFrom;
//use std::ops::RangeFrom;
//use std::num::f64;
//use std::convert::TryFrom;
//use std::option::unwrap_or_else;


pub fn nth(n: u32) -> u32 {
	println!("n={}",n);
   let r: Option<u32> = (1..)
      .map(|x| 2 * x)
	  .filter(|x| is_prime(x))
      .take((n+1) as usize)
      .last();
	  match r {
		  None => return 0 as u32,
		  Some(r) => return r,
	  }
}

pub fn is_prime(n: &u32) -> bool {
let m = ((*n as f32).sqrt() as u32)+1;
    !(2..m).any(|x| n % x == 0)
}