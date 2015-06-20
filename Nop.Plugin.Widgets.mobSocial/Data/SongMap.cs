﻿using Nop.Plugin.Widgets.MobSocial.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Widgets.MobSocial.Data
{
    class SongMap : EntityTypeConfiguration<Song>
    {
        public SongMap()
        {
            ToTable(typeof(Song).Name);
            HasKey(x => x.Id);

            Property(x => x.PageOwnerId);
            Property(x => x.Name);
            Property(x => x.Description);
            Property(x => x.RemoteEntityId);
            Property(x => x.RemoteSourceName);
            Property(x => x.RemoteArtistId);
            Property(x => x.PreviewUrl);
            Property(x => x.TrackId);
            
            
        }
    }
}
