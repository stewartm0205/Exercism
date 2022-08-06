package Clock;

use Moo;
use feature qw<say>;

# rwp = read-write protected
has hour   => ( is => 'rwp' );
has minute => ( is => 'rwp' );

sub time {
    open (O,">>","out.txt");
    my ($self) = @_;
    print O "self=", %$self, "\n";
    my $hour=%$self{'hour'};
    my $minute=%$self{'minute'};
    print O "hour=",$hour,", minute=",$minute,"\n";
    if ($minute>60) {
        $hour += int $minute / 60;
        $minute = $minute % 60;
    } else {
       $hour -= int $minute / 60;
       $hour -= 1;
       $minute = abs($minute % 60);
    }
    if ($hour>=24) {
        $hour = $hour % 24;
    } else {
       $hour = abs( $hour % 24);
    }
    close (O);
    bless $self;
    return $self;
}

sub add_minutes {
    my ( $self, $amount ) = @_;
    $self->{"minute"} += $amount;
    return Clock->time($self);
}

sub subtract_minutes {
    my ( $self, $amount ) = @_;
    $self->{"minute"} -= $amount;
    return Clock->time($self);
}

1;
