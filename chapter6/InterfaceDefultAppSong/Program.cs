using SongLibInterfaceDefult;

Song song=new();

song.Play();

IPlayable playable=song;
playable.Pause();