# perl-service.pl
use Mojolicious::Lite;

get '/textprocess' => sub {
    my $c = shift;
    $c->render(text => 'Perl Service: Text processed successfully!');
};

app->start;
